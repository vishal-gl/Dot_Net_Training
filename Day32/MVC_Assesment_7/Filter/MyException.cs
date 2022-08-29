using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assesment_7.Filter
{
    public class MyException : FilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is CustomException m)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                CustomException custException = new CustomException(m.message);

                var model = new HandleErrorInfo(custException, controllerName, actionName);

                filterContext.Result = new ViewResult()
                {
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),

                    ViewName = "CustomError"
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}