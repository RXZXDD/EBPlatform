using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using EBPlatform.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBPlatform.Models

{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProductContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcProductContext>>()))
            {
                if(context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    new Product
                    {
                        PName = "USP",
                        PDescribe = "A Pistal",
                        PPrice = 2.99M,
                        PNum = 99
                    },
                    new Product
                    {
                        PName = "M4A1",
                        PDescribe = "A Rifle",
                        PPrice = 3100M,
                        PNum = 99
                    },
                    new Product
                    {
                        PName = "AWP",
                        PDescribe = "A Anti-ArmorRifle",
                        PPrice = 4750M,
                        PNum = 99
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
