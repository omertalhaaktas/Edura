using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Edura.Models
{
    public class EduraInitializer : DropCreateDatabaseAlways<EduraContext>
    {
        protected override void Seed(EduraContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() {Name="Furniture"},
                new Category() {Name="Electronics"},
                new Category() {Name="Books"},
                new Category() {Name="Accessories"},
                new Category() {Name="Computers"},
                new Category() {Name="Camera"}
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            List<Product> products = new List<Product>()
            {
                new Product() {Name="Photo Camera", Image="product1.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= true,isHome=true, Price=99, CategoryId=6},
                new Product() {Name="Comfortable Sofa", Image="product3.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= true,isHome=true, Price=49, CategoryId=1},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, isHome=true,Price=79, CategoryId=1},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= true,isHome=true, Price=79, CategoryId=2},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false,isHome=true, Price=79, CategoryId=2},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= true, Price=79, CategoryId=2},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, Price=79, CategoryId=3},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, Price=79, CategoryId=3},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, Price=79, CategoryId=3},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, Price=79, CategoryId=4},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, Price=79, CategoryId=4},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, Price=79, CategoryId=4},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= true, Price=79, CategoryId=5},
                new Product() {Name="Hand Bag", Image="product4.jpg", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", isApproved=true, isFeatured= false, Price=79, CategoryId=5}
            };

            foreach (Product product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}