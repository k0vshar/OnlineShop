using Microsoft.EntityFrameworkCore;
using OnlineShop.DB.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.DB
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Compare> Compares { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOne(u => u.OrderDetails).WithOne().HasForeignKey<OrderDetails>(x => x.Id);
            modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(g => g.Category)
            .HasForeignKey(g => g.CategoryId);


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Корм" },
                new Category { Id = 2, Name = "Игрушки" },
                new Category { Id = 3, Name = "Миски и кормушки" },
                new Category { Id = 4, Name = "Поводки и ошейники" },
                new Category { Id = 5, Name = "Уход и гигиена" }
            );

            // product1
            var product1Id = Guid.Parse("168defec-16fe-4dec-8db1-8d968036bd89");
            var image1Product1 = new Image()
            {
                Id = Guid.Parse("2f33830e-c282-406c-9484-131dc36caa5c"),
                URL = "/img/products/notebook_MSI_Katana_17_B12VEK-482XRU_1.jpg",
                ProductId = product1Id
            };
            var image2Product1 = new Image()
            {
                Id = Guid.Parse("d1f639d8-ee07-4a1c-92a6-37b9b85f261d"),
                URL = "/img/products/notebook_MSI_Katana_17_B12VEK-482XRU_2.jpg",
                ProductId = product1Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product1, image2Product1);

            // product2
            var product2Id = Guid.Parse("06fe75f0-09f2-4489-8d11-42f6c816baef");
            var image1Product2 = new Image()
            {
                Id = Guid.Parse("cec15667-ebba-40a6-8f00-6b82825ae2df"),
                URL = "/img/products/tv_Samsung_QE43Q60BAU_1.jpg",
                ProductId = product2Id
            };
            var image2Product2 = new Image()
            {
                Id = Guid.Parse("d8052407-64bc-4543-b1ba-7da5fac09516"),
                URL = "/img/products/tv_Samsung_QE43Q60BAU_2.jpg",
                ProductId = product2Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product2, image2Product2);

            // product3
            var product3Id = Guid.Parse("d3765151-d68f-41ea-a8b9-27bae6f2b8a0");
            var image1Product3 = new Image()
            {
                Id = Guid.Parse("34712b35-335b-4863-a109-0bfb0c612938"),
                URL = "/img/products/Refrigerator_Midea_MDRB499FGF01IM_1.jpg",
                ProductId = product3Id
            };
            var image2Product3 = new Image()
            {
                Id = Guid.Parse("c841fc87-3d4c-47be-ae15-fce88542d3c3"),
                URL = "/img/products/Refrigerator_Midea_MDRB499FGF01IM_2.jpg",
                ProductId = product3Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product3, image2Product3);

            // product4
            var product4Id = Guid.Parse("1f06e50b-989b-4827-89db-4859d1d49998");
            var image1Product4 = new Image()
            {
                Id = Guid.Parse("e469883a-82d5-4b1e-9538-fe6d05dd1360"),
                URL = "/img/products/Robot_Vacuum_Cleaner_Dreame_Bot_Robot_Vacuum_and_Mop_F9_Pro_1.jpg",
                ProductId = product4Id
            };
            var image2Product4 = new Image()
            {
                Id = Guid.Parse("683efc32-0514-44a8-bda8-eb3ea45e3f42"),
                URL = "/img/products/Robot_Vacuum_Cleaner_Dreame_Bot_Robot_Vacuum_and_Mop_F9_Pro_2.jpg",
                ProductId = product4Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product4, image2Product4);

            // product5
            var product5Id = Guid.Parse("2c9d0079-8bdd-43bb-beba-bcde5a43d6c7");
            var image1Product5 = new Image()
            {
                Id = Guid.Parse("91db92bb-3e37-4219-9fcc-62b3d670a15c"),
                URL = "/img/products/Electric_oven_Gorenje_BO6737E02X_1.jpg",
                ProductId = product5Id
            };
            var image2Product5 = new Image()
            {
                Id = Guid.Parse("b2681e3d-da09-41e5-8df0-9867bc47e4f2"),
                URL = "/img/products/Electric_oven_Gorenje_BO6737E02X_2.jpg",
                ProductId = product5Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product5, image2Product5);

            // product6
            var product6Id = Guid.Parse("6f74b568-cf38-4caa-92c3-dbc45437a2aa");
            var image1Product6 = new Image()
            {
                Id = Guid.Parse("cf1b1834-bdb7-4fbe-82a2-4dd06d635640"),
                URL = "/img/products/Air_conditioner_Haier_HSU7HRM3_1.jpg",
                ProductId = product6Id
            };
            var image2Product6 = new Image()
            {
                Id = Guid.Parse("67dea053-c686-41a5-9e37-bf33ae82bada"),
                URL = "/img/products/Air_conditioner_Haier_HSU7HRM3_2.jpg",
                ProductId = product6Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product6, image2Product6);

            // product7
            var product7Id = Guid.Parse("2842320a-f42d-4f81-880f-488778526f5d");
            var image1Product7 = new Image()
            {
                Id = Guid.Parse("b6596218-042a-48b7-a62e-38ce8ed7ddd0"),
                URL = "/img/products/Freezer_Haier_HF-82WAA_1.jpg",
                ProductId = product7Id
            };
            var image2Product7 = new Image()
            {
                Id = Guid.Parse("a9ccb1f9-56e1-46f5-80f2-5391b9422750"),
                URL = "/img/products/Freezer_Haier_HF-82WAA_2.jpg",
                ProductId = product7Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product7, image2Product7);

            // product8
            var product8Id = Guid.Parse("7f15a38b-fcb6-4241-87e8-8148e148e5b4");
            var image1Product8 = new Image()
            {
                Id = Guid.Parse("f5de0b00-1a25-4602-923d-661df4acc2f7"),
                URL = "/img/products/Built-in_electric_panel_Gorenje_ECT641BX_1.jpg",
                ProductId = product8Id
            };
            var image2Product8 = new Image()
            {
                Id = Guid.Parse("b5c66945-d510-49d7-811d-0383d46fdab8"),
                URL = "/img/products/Built-in_electric_panel_Gorenje_ECT641BX_2.jpg",
                ProductId = product8Id
            };
            modelBuilder.Entity<Image>().HasData(image1Product8, image2Product8);


            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = product1Id,
                   Name = "Рулетка Flexi New Classic S 5м Синяя",
                   Cost = 550,
                   CategoryId = 4,
                   Description = "Лінійка New Classic — перевірена часом серія повідців-рулеток для приємних прогулянок із вихованцем. Рулетки Flexi New Classic S характеризуються надійністю та зручністю.",
               },
               new Product()
               {
                   Id = product2Id,
                   Name = "Сухий корм для дорослих собак Club 4 Paws (Клуб 4 Лапи) Преміум для середніх порід 14 кг",
                   Cost = 1680,
                   CategoryId = 1,
                   Description = "Сухий раціон містить м’ясні інгредієнти на першому місці у Складі, збалансоване поєднання білків та жирів 24/13 та чудово смакує собакам середніх порід вагою від 11 до 25 кг і віком від 1 року.",
               },
               new Product()
               {
                   Id = product3Id,
                   Name = "М'яч бейсбольний Denta Fun Mintfresh Trixie 3289 7 см",
                   Cost = 178,
                   CategoryId = 2,
                   Description = "Свійські тварини незмінно залишаються в центрі уваги компанії Trixie вже понад 40 років. Цікавість і любов до свійських тварин і їхніх власників допомагають компанії безперервно розвиватися. Широкий діапазон продуктів компанії експортується до понад 60 країн.",
               },
               new Product()
               {
                   Id = product4Id,
                   Name = "Годівниця та поїлка для котів та собак Hoopet 2 x 3.5L, комплект Сірий",
                   Cost = 1235,
                   CategoryId = 3,
                   Description = "Не завжди встигаєте чи забуваєте нагодувати та напоїти свого домашнього улюбленця? Тоді цей комплект поїлки та годівниці саме те, що вам потрібно. Він подбає про те, щоб ваш вихованець завжди отримав свіжу порцію корму та питної води.",
               },
               new Product()
               {
                   Id = product5Id,
                   Name = "Шампунь Trixie 2910 з маслами макадамії і обліпихи 1л",
                   Cost = 368,
                   CategoryId = 5,
                   Description = "Шампунь Trixie з оліями макадамії й обліпихи для собак — прекрасний варіант для купання тварин, чия шерсть потребує додаткового підживлення корисними речовинами.",
               }
             );
        }
    }
}
