﻿using Insurance.Web.Filter;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            ///注册全局筛选器
            filters.Add(new ExceptionAttribute());
            filters.Add(new AuthAttribute());
        }
    }
}