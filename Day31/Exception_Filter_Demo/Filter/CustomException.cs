using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exception_Filter_Demo.Filter
{
    public class CustomException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if(filterContext.Exception is NotImplementedException)
            {
                ViewResult view = new ViewResult();
                view.ViewName = "Error";
                view.ViewBag["Message"] = "This is Wrong";
                filterContext.Result = view;
                filterContext.ExceptionHandled = true;
            }
            //filterContext.Result = new ViewResult()
            //{ 
            //    ViewName = "Contact",
                
            //};
            filterContext.ExceptionHandled = true;
        }
    }
}