using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concreate
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Products)
                .UsingEntity<ProductCategory>();

            modelBuilder.Entity<Category>()
                .HasIndex(e => e.Url)
                .IsUnique();




            modelBuilder.Entity<Product>().HasData(
                new List<Product>()
                {

                    new (){Id = 1, Name ="Samsung Electra 2022",Price=30000,Description="normal telefon"},
                       new (){Id = 2, Name ="Samsung S53 ",Price=10000,Description="normal telefon"},
                          new (){Id = 3, Name ="Samsung A52",Price=15000,Description="normal telefon"},
                             new (){Id = 4, Name ="Samsung Galaxy M20",Price=5000,Description="normal telefon"},
                                new (){Id = 5, Name ="Monster",Price=70000,Description="normal bilgisayar"},
                             new (){Id = 6, Name ="Lenovo",Price=60000,Description="normal bilgisayar"},
                             new (){Id = 7, Name ="IPhome A10",Price=120000,Description="normal telefon"},
                          new (){Id = 8, Name ="IPhome S20",Price=14000,Description="normal telefon"},
                               new (){Id = 9, Name ="IPhome S21",Price=14000,Description="güzel telefon"},
                                    new (){Id = 10, Name ="IPhome S22",Price=14000,Description="orta telefon"},
                                         new (){Id =11, Name ="IPhome S23",Price=14000,Description="muhteşem telefon"},
                                            new (){Id =12, Name ="Camaşır Makinası",Price=30000,Description="orta makine"}
                }
                );

            modelBuilder.Entity<Category>().HasData(
                new List<Category>()
                {
                    new () {Id=1, Name="Telefon",Url="telefon"},
                    new () {Id=2,Name="Bilgisayar",Url="Bilgisayar"},
                       new () {Id=3,Name="Beyaz Eşya",Url="beyaz-esya"}
                }



                );


            modelBuilder.Entity<ProductCategory>().HasData(
                new List<ProductCategory>()
                {
                    new ProductCategory() {ProductId=1,CategoryId=1},
                    new ProductCategory() {ProductId=2,CategoryId=1},
                    new ProductCategory() {ProductId=3,CategoryId=1 },
                    new ProductCategory() {ProductId=4,CategoryId=1},
                    new ProductCategory() {ProductId=5,CategoryId=2},
                    new ProductCategory() {ProductId=6,CategoryId=2},
                    new ProductCategory() {ProductId=7,CategoryId=1},
                    new ProductCategory() {ProductId=8,CategoryId=1,},
                    new ProductCategory() {ProductId=9,CategoryId=1},
                    new ProductCategory() {ProductId=10,CategoryId=1},
                    new ProductCategory() {ProductId=11,CategoryId=1},
                    new ProductCategory() {ProductId=12,CategoryId=3}

                    

                }
                );


        }
    }
}
