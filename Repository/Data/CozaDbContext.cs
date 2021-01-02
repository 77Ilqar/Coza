using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
    public class CozaDbContext:DbContext
    {
        public CozaDbContext(DbContextOptions<CozaDbContext> options) : base(options) { }

        public DbSet<Category> Categories  { get; set; }
        public DbSet<Department> Departments  { get; set; }
        public DbSet<Discount> Discounts  { get; set; }
        public DbSet<Favorite> Favorites  { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts  { get; set; }
        public DbSet<ProductOption> ProductOptions  { get; set; }
        public DbSet<ProductOptionItem> ProductOptionItems  { get; set; }
        public DbSet<ProductPhoto> ProductPhotos  { get; set; }
        public DbSet<ProductReview> ProductReviews  { get; set; }
        public DbSet<ProductSpecs> ProductSpecs  { get; set; }
        public DbSet<Setting> Settings  { get; set; }
        public DbSet<ShopCollection> ShopCollections  { get; set; }
        public DbSet<SliderItem> SliderItems  { get; set; }
        public DbSet<User> Users  { get; set; }

    }
}
