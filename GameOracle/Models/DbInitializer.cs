using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOracle.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Games.Any())
            {
                context.AddRange(

                    new Game("Scythe", 1, 5),
                    new Game("Catan", 2, 5),
                    new Game("Carcasonne", 2, 5)
                );

                context.SaveChanges();
            }
        }
    }
}
