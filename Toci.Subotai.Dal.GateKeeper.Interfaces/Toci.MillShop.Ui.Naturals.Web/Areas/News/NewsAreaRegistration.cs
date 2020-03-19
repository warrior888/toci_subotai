﻿using System.Web.Mvc;

namespace Toci.MillShop.Ui.Naturals.Web.Areas.News
{
    public class NewsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "News";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "News_default",
                "News/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}