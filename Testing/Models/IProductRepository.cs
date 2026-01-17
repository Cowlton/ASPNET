using System.Collections.Generic;
using System;
namespace Testing.Models;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}