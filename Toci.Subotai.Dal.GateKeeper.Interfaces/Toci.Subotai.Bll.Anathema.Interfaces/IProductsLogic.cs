using System.Collections.Generic;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.Subotai.Bll.Anathema.Interfaces
{
    public interface IProductsLogic
    {
        Product GetProduct(int Id);

        List<Product> GetProducts();

        List<Product> GetProductsForPromo();

        List<Product> GetAssociatedProducts(int IdBaseProduct);

    }
}