﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Interfaces;
using OnlineShop.DB.Models;
using OnlineShopWebApp.Connected_Services;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryStorage _categoryStorage;
        private readonly IProductStorage _productStorage;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly UserViewModel _userViewModel;

        public ProductController(IProductStorage productStorage, ICategoryStorage categoryStorage, IReviewStorage reviewStorage, IHttpClientFactory httpClientFactory, UserManager<User> userManager, UserViewModel userViewModel, IMapper mapper = null)
        {
            _categoryStorage = categoryStorage;
            _productStorage = productStorage;
            _mapper = mapper;
            _httpClientFactory = httpClientFactory;
            _userManager = userManager;
            _userViewModel = userViewModel;
    }

        public async Task<IActionResult> Details(int? categoryId)
        {
            var products = await _productStorage.GetAllAsync(); 

            if (categoryId.HasValue)
            {
                products = products.Where(g => g.CategoryId == categoryId.Value).ToList(); // ✅ фильтрация
            }

            var categories = _categoryStorage.GetAll(); // синхронно, если метод не async

            var model = new ProductViewModel
            {
                Products = products,
                Categories = categories.ToList(),
                SelectedCategoryId = categoryId
            };

            return View(model);
        }



        public async Task<IActionResult> Index(Guid productId)
        {
            var httpClient = _httpClientFactory.CreateClient("ReviewWebAPI");
            var reviews = await httpClient.GetFromJsonAsync<List<ReviewViewModel>>($"/Review/GetAllByProductId?productId={productId}") ?? new List<ReviewViewModel>();

            var product = await _productStorage.TryGetByIdAsync(productId);
            var productViewModel = _mapper.Map<ProductViewModel>(product);
            productViewModel.Reviews = reviews;
            return productViewModel != null ? View(productViewModel) : View("Error");
        }

        public async Task<IActionResult> ViewAsync(int page = 1, int itemsOnPage = 1)
        {
            var products = (await _productStorage.GetProductsWithPaginationAsync(page, itemsOnPage));
            var productsViewModel = _mapper.Map<List<ProductViewModel>>(products);
            return products != null ? View(products) : View("Error");
        }

        public async Task<IActionResult> SearchAsync(string search) 
        {
            ViewData["Search"] = search;
            search = search.ToLower();
            var products = (await _productStorage.GetAllAsync()).Where(p => p.Name.ToLower().Contains(search) || p.Description.ToLower().Contains(search)).ToList();
            var productsViewModel = _mapper.Map<List<ProductViewModel>>(products);
            return View(productsViewModel);
        }

        public IActionResult AddReview(Guid productId)
        {
            var ReviewViewModel = new ReviewViewModel() { ProductId = productId };
            return View(ReviewViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddReviewAsync(ReviewViewModel reviewViewModel)
        {
            var userId = User.Identity.IsAuthenticated ? (await _userManager.GetUserAsync(HttpContext.User)).Id : _userViewModel.Id.ToString();
            reviewViewModel.UserId = Guid.Parse(userId);
            var httpClient = _httpClientFactory.CreateClient("ReviewWebAPI");
            await httpClient.PostAsJsonAsync($"/Review/Add", reviewViewModel);

            return RedirectToAction("Index", new { productId = reviewViewModel.ProductId });
        }
    }
}