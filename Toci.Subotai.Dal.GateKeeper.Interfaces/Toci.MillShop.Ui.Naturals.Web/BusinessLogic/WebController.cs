﻿using System.Web.Mvc;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

//using System.Data.Entity.DbContext;


namespace Toci.MillShop.Ui.Naturals.Web.BusinessLogic
{
    public class WebController : Controller
    {
        protected subotaiEntities SubotaiEntities;

        public WebController(subotaiEntities subotaiEntities)
        {
            SubotaiEntities = subotaiEntities;
        }
    }
 
}