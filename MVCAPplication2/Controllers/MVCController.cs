using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class MVCController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }


        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var controller = new MVCController();

            // Act
            var result = controller.Index() as ContentResult;

           
            Assert.AreEqual("Hello World!!.", result.Content);
        }

       

    }
   

   

}
