﻿using BetSystem.Web.Infrastructure.Filters;
using System.Web;
using System.Web.Mvc;

namespace BetSystem.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }
    }
}
