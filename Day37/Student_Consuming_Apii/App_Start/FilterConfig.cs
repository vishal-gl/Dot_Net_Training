﻿using System.Web;
using System.Web.Mvc;

namespace Student_Consuming_Apii
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
