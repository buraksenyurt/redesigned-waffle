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
            if (context.Waffles.Any()) return;
            context.Waffles.AddRange(
                new Waffle
                {
                    Id=1,
                    Title= "Classic Waffles",
                    Ingradients = new List<string> { "2 cups all-purpose flour", "1 teaspoon salt", "4 teaspoons baking powder", "2 tablespoons white sugar", "2 eggs", "1 ½ cups warm milk", "⅓ cup butter, melted", "1 teaspoon vanilla extract" },
                    InStock=true,
                    Recipe= "In a large bowl, mix together flour, salt, baking powder and sugar; set aside. Preheat waffle iron to desired temperature.In a separate bowl, beat the eggs. Stir in the milk, butter and vanilla. Pour the milk mixture into the flour mixture; beat until blended.Ladle the batter into a preheated waffle iron. Cook the waffles until golden and crisp. Serve immediately."
                },
                new Waffle
                {
                    Id = 2,
                    Title = "Coconut Chocolate Chip Waffles",
                    Ingradients = new List<string> { "1 cup bread flour", "1 cup oat flour", "2 tablespoons white sugar", "1  tablespoon baking powder", "½ teaspoon ground cinnamon", "½ teaspoon salt", "1 ⅔ cups unsweetened almond milk", "½ cup unsweetened applesauce","⅓ cup coconut oil, melted", "½ cup chocolate chips" },
                    InStock = false,
                    Recipe = "Preheat a waffle iron according to manufacturer's instructions. Whisk bread flour, oat flour, sugar, baking powder, cinnamon, and salt together in a bowl. Mix almond milk, applesauce, and coconut oil together in a separate bowl; stir into flour mixture until batter is just combined. Fold chocolate chips into batter; let stand for 5 minutes. Scoop 1/4 to 1/2 cup batter into preheated waffle iron; cook according to manufacturer's instructions, about 4 minutes per waffle."
                }
            );
            context.SaveChanges();
        }
    }
}
