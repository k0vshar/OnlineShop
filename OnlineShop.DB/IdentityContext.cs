﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DB.Models;

namespace OnlineShop.DB
{
    public class IdentityContext : IdentityDbContext<User, UserRole, string>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options): base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
