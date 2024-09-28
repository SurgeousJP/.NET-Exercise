using ProductManagement.Models;
using ProductManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProductManagement.Services
{
    public class ProductService
    {
        private ProductRepository _animalRepository = new ProductRepository();

        public List<ProductDTO> GetAllProducts(Expression<Func<Product, bool>> predicate = null)
        {
            return _animalRepository.GetAllProducts(predicate);
        }

        public void SaveProduct(ProductDTO animalDTO)
        {
            _animalRepository.SaveProduct(animalDTO);
        }

        public void DeleteProduct(Func<Product, bool> predicate)
        {
            _animalRepository.DeleteProduct(predicate);
        }

        public ProductDTO GetMaxPriceProduct()
        {
            return _animalRepository.GetMaxPriceProduct();
        }

        public void DeleteAllProduct()
        {
            _animalRepository.DeleteAllProduct();
        }
    }
}
