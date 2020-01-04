using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smaczne.ukw.edu.pl.Models
{
    public class IProductRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
