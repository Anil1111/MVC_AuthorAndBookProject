﻿using System.Web;
using System.Web.Mvc;

namespace Quiz1_mariamCharkviani
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
