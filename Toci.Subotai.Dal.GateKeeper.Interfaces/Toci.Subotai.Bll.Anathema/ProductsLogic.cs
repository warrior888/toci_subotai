using System.Collections.Generic;
using Toci.Subotai.Bll.Anathema.Interfaces;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.Subotai.Bll.Anathema
{
    public class ProductsLogic : IProductsLogic 
    {
        public Product GetProduct(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProductsForPromo()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAssociatedProducts(int IdBaseProduct)
        {
            return null;
        }
    }
}