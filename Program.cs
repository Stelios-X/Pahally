using Pahally.Data;
using Pahally.Models;
using System;

namespace Pahally
{
    class Program
    {
        static void Main(string[] args)
        {
            using PahallyContext context = new PahallyContext();

            Product squeakyBone = new Product()
            {
                Name = "Squeaky Dog Bone",
                Price = 4.99M
            };
            context.Products.Add(squeakyBone);

            Product tennisBalls = new Product()
            {
                Name = "Tennis Ball 3-pack",
                Price = 9.99M
            };
            context.Add(tennisBalls);

            context.SaveChanges();



        }
    }
}
