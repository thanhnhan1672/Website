using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

namespace 
    BooksStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context =
            app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < BooksStoreDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())   
            {
                context.Books.AddRange(
                new Book
                {
                    Title = "Bàn Học Gaming",
                    Description = "Bàn Gỗ chất lượng cao , làm từ gỗ nguyên chất,sử dụng trong công việc rất tốt...",
                Genre = "Bàn",
                    Price = 1111.98m
                },
                new Book
                {
                    Title = "Ghế Gaming Extreme Zero S (Red – Black) ",
                    Description = "Ghế có đầy đủ gối lưng, gối đầu giúp giảm đau mỏi cổ, thắt lưng khi ngồi lâu.",
                    


                Genre = "Ghế",
                    Price = 127.46m
                },
                new Book
                {
                    Title = "Laptop MSI Gaming ",
                    Description = "Thin 10SC-481VN i7 10750H/8GB/512GB/15.6FHD / GTX 1650 Max - Q 4GB / Win 10",
                Genre = "laptop",
                    Price = 193.41m
                },
                new Book
                {
                    Title = "Ghế Gaming Extreme Zero S+",
  Description = "Có khả năng ngả 135 + 20 độ, xoay, nâng hạ nghỉ ngơi cực thoải mái Thiết kế cứng cáp, chắc chắn chịu lực lên tới 90kg",
                Genre = "Ghế",
                    Price = 128.69m
                },
                new Book
                {
                    Title = "MSI GF63 Thin 10SCXR-222US Core i5 10500H 8GB 256GB SSD 15.6 inch FHD GTX1650 Windows 10",
    Description = "Sử dụng trong công việc , việc học , chơi game ... có khả năng làm việc tốt",
                Genre = "Laptop",
                    Price = 311.26m
                }
                );

                context.SaveChanges();
            }
        }
    }
}