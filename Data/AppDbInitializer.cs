using book_review1.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace book_review1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "First book Title",
                        Description = "First book Description",
                        IsRead = true,
                        DateRead = System.DateTime.Now.AddDays(-10),
                        Rate = 5,
                        Genre = "Romance",
                        Author = "First Au",
                        CoverUrl = "Https...",
                        DateAdded = System.DateTime.Now
                    },
                    new Book()
                    {
                        Title = "Second book Title",
                        Description = "Second book Description",
                        IsRead = false,


                        Genre = "Romance",
                        Author = "First Au",
                        CoverUrl = "Https...",
                        DateAdded = System.DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
