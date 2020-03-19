using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Toci.MillShop.Ui.Naturals.Web.BusinessLogic;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.MillShop.Ui.Naturals.Web.Controllers
{
    [Authorize]
    public class HomeController : WebController
    {
        public ActionResult Index()
        {
            List<Product> prodsList = SubotaiEntities.Products.Where((product, isActive) => product.Price.Value > 4).ToList();



            return View(prodsList);
        }

        public HomeController( ) : base(new subotaiEntities())
        {
        }
    }
}
