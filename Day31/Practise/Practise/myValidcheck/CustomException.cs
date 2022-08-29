using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practise.MyException;

namespace Practise.myValidcheck
{
    public class CustomException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if(filterContext.Exception is MyException1 m)
            {
                 string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                MyException1 custException = new MyException1(m.msg1);

                var model = new HandleErrorInfo(custException, controllerName, actionName);

                filterContext.Result = new ViewResult()
                {
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                 
                    ViewName = "Error2"
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}