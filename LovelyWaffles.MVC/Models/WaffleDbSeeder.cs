using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LovelyWaffles.MVC.Models
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
                    Ingradients = new List<Ingradient>
                    {
                        new Ingradient{IngradientId=1,Description="2 cups all-purpose flour" }
                        ,new Ingradient{IngradientId=2, Description="1 teaspoon salt" }
                        ,new Ingradient{IngradientId=3, Description="4 teaspoons baking powder" }
                        ,new Ingradient{IngradientId=4,Description= "2 tablespoons white sugar" }
                        ,new Ingradient{IngradientId=5,Description= "2 eggs" }
                        ,new Ingradient{IngradientId=6,Description= "1 ½ cups warm milk" }
                        ,new Ingradient{IngradientId=7,Description= "⅓ cup butter, melted" }
                        ,new Ingradient{IngradientId=8,Description="1 teaspoon vanilla extract" }
                    },
                    Recipe = "In a large bowl, mix together flour, salt, baking powder and sugar; set aside. Preheat waffle iron to desired temperature.In a separate bowl, beat the eggs. Stir in the milk, butter and vanilla. Pour the milk mixture into the flour mixture; beat until blended.Ladle the batter into a preheated waffle iron. Cook the waffles until golden and crisp. Serve immediately."
                });

            context.Waffles.Add(new Waffle
            {
                WaffleId = 2,
                Title = "coconut chocolate chip waffles",
                InStock = false,
                Ingradients = new List<Ingradient>
                {
                    new Ingradient{IngradientId=9,Description="1 cup bread flour" }
                    ,new Ingradient{IngradientId=10, Description="1 cup oat flour" }
                    ,new Ingradient{IngradientId=11, Description="2 tablespoons white sugar" }
                    ,new Ingradient{IngradientId=12,Description= "1  tablespoon baking powder" }
                    ,new Ingradient{IngradientId=13,Description= "½ teaspoon ground cinnamon" }
                    ,new Ingradient{IngradientId=14,Description= "½ teaspoon salt" }
                    ,new Ingradient{IngradientId=15,Description= "1 ⅔ cups unsweetened almond milk" }
                    ,new Ingradient{IngradientId=16,Description="½ cup unsweetened applesauce" }
                    ,new Ingradient{IngradientId=17,Description="⅓ cup coconut oil, melted" }
                    ,new Ingradient{IngradientId=18,Description="½ cup chocolate chips" }
                },
                Recipe = "preheat a waffle iron according to manufacturer's instructions. whisk bread flour, oat flour, sugar, baking powder, cinnamon, and salt together in a bowl. mix almond milk, applesauce, and coconut oil together in a separate bowl; stir into flour mixture until batter is just combined. fold chocolate chips into batter; let stand for 5 minutes. scoop 1/4 to 1/2 cup batter into preheated waffle iron; cook according to manufacturer's instructions, about 4 minutes per waffle."
            });

            context.SaveChanges();
        }
    }
}
