using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Moq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tweeter;
using Tweeter.DAL;
using Tweeter.Models;
using Tweeter.Controllers;

namespace Tweeter.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        Mock<TweeterContext> mock_context { get; set; }
        Mock<DbSet<Tweet>> mock_tweet_table { get; set; }
        Mock<DbSet<Twit>> mock_twit_table { get; set; }
        AccountController repo { get; set; }


        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
