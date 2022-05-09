using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(string sort)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
            AddOrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc": 
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc": 
                        AddOrderByDescending(p => p.Price);
                        break;
                    case "nameAsc": 
                        AddOrderBy(p => p.Name);
                        break;
                    case "nameDesc": 
                        AddOrderByDescending(p => p.Name);
                        break;
                    default :
                        AddOrderBy(p => p.Name);
                        break;
                }       
            }
            
        }

        public ProductsWithTypesAndBrandsSpecification(int id): base (x => x.Id == id)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}