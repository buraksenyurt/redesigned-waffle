using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LovelyWaffles.RazorPages.Data
{
    public class WaffleDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new WaffleDbContext(serviceProvider.GetRequiredService<DbContextOptions<WaffleDbContext>>());
            if (context.Waffles.Any())
                return;
            context.Waffles.Add(
                new Waffle
                {
                    WaffleId = 1,
                    Title = "Classic Waffles",
                    InStock = true,
                    Recipe = "In a large bowl, mix together flour, salt, baking powder and sugar; set aside. Preheat waffle iron to desired temperature.In a separate bowl, beat the eggs. Stir in the milk, butter and vanilla. Pour the milk mixture into the flour mixture; beat until blended.Ladle the batter into a preheated waffle iron. Cook the waffles until golden and crisp. Serve immediately."
                });

            context.Waffles.Add(new Waffle
            {
                WaffleId = 2,
                Title = "coconut chocolate chip waffles",
                InStock = false,
                Recipe = "preheat a waffle iron according to manufacturer's instructions. whisk bread flour, oat flour, sugar, baking powder, cinnamon, and salt together in a bowl. mix almond milk, applesauce, and coconut oil together in a separate bowl; stir into flour mixture until batter is just combined. fold chocolate chips into batter; let stand for 5 minutes. scoop 1/4 to 1/2 cup batter into preheated waffle iron; cook according to manufacturer's instructions, about 4 minutes per waffle."
            });

            context.SaveChanges();
        }
    }
}
