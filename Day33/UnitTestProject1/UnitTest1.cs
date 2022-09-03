using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using Task_Prod_Catagory.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodViewName1()

        {
            //Arrange
            CustomerController c = new CustomerController();

            //Act
            ViewResult v = c.Index(0) as ViewResult;
            //Assert
            Assert.AreEqual<string>("View1", v.ViewName);
        }
        [TestMethod]
        public void TestForViewName2()
        {
            //Arrange
            CustomerController c = new CustomerController();
            //Act
            ViewResult v = c.Index(1) as ViewResult;
            //Assert
            Assert.AreEqual<string>("View2", v.ViewName);
        }
        [TestMethod]

        public void TestForView2()
        {
            CustomerController c = new CustomerController();
            ViewResult v = c.Index2() as ViewResult;
            Assert.AreEqual<string>("SomeValue", v.ViewData["MyKey"].ToString());

        }
    }
}
