﻿using System.Web;
using System.Web.Mvc;

namespace Colossious_Asp.net_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
