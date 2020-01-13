using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smaczne.ukw.edu.pl.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Hawajska",
                        Description = "sos pomidorowy, ser, szynka, ananas",
                        Category = "Pizza 50cm ",
                        Price = 39
                    },
                    new Product
                    {
                        Name = "Milano",
                        Description = "sos pomidorowy, ser mozzarella, kiełbasa chorizo, cebula, papryka, jalapeno",
                        Category = "Pizza 50 cm ",
                        Price = 32
                    },
                    new Product
                    {
                        Name = "Prosciutto",
                        Description = "sos pomidorowy, ser, szynka szwarcwaldzka, pomidor koktajlowy, rukola, płatki sera twardego",
                        Category = "Pizza 50 cm",
                        Price = 34
                    },
                    new Product
                    {
                        Name = "Pierogi Bigosowe 6 szt",
                        Description = "Pierogi z bigosem",
                        Category = "Kuchnia polska",
                        Price = 22
                    },
                    new Product
                    {
                        Name = "Pierogi Ruskie 6 szt",
                        Description = "Pierogi ruskie (ziemniaki, twaróg, cebula ",
                        Category = "Kuchnia polska",
                        Price = 19
                    },
                    new Product
                    {
                        Name = "Pierogi z serem 6 szt",
                        Description = "Pierogi z serem twarogowym na słodko",
                        Category = "Kuchnia Polska",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Pomidorówka",
                        Description = "Zupa z pomidorów, 450 ml",
                        Category = "Zupy",
                        Price = 9
                    },
                    new Product
                    {
                        Name = "Rosół",
                        Description = "Zupa z kury, 450 ml",
                        Category = "Zupy",
                        Price = 6
                    },
                    new Product
                    {
                        Name = "Barszcz",
                        Description = "Zupa z buraków, 450 ml",
                        Category = "Zupy",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Zestaw 19 szt",
                        Description = "hosomaki łosoś, krewetki w tempurze oraz 1 rolka do wyboru ",
                        Category = "Sushi",
                        Price = 37
                    },
                    new Product
                    {
                        Name = "Zestaw 40 szt",
                        Description = "futomaki: dorada tempura i wege w tempurze, hosomaki: łosoś, tuńczyk, łosoś pieczony, krewetka, surimi, ogórek, +2 wybrane rolki ",
                        Category = "Sushi",
                        Price = 59
                    },
                    new Product
                    {
                        Name = "Zestaw 78 szt",
                        Description = "hosomaki: łosoś, tuńczyk, łosoś pieczony, krewetka, surimi, ogórek, oshinko tempura oraz california dorada tempura + 2 wybrane rolki ",
                        Category = "Sushi",
                        Price = 79
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
