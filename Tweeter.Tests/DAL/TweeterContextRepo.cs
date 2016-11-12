using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tweeter.DAL;
using Tweeter.Models;
using Tweeter.Controllers;
using System.Data.Entity;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Tweeter.Tests.DAL
{
    [TestClass]
    public class TweeterContextRepo
    {
        Mock<TweeterContext> mock_context { get; set; }
        Mock<DbSet<Twit>> mock_users { get; set; }
        TweeterRepository repo { get; set; }
        List<Twit> users { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<TweeterContext>();
            mock_users = new Mock<DbSet<Twit>>();
            repo = new TweeterRepository(mock_context.Object);
        }

        public void ConnectToDatastore()
        {
            users = new List<Twit>();
            var query_users = users.AsQueryable();

            mock_users.As<IQueryable<Twit>>().Setup(m => m.Provider).Returns(query_users.Provider);
            mock_users.As<IQueryable<Twit>>().Setup(m => m.Expression).Returns(query_users.Expression);
            mock_users.As<IQueryable<Twit>>().Setup(m => m.ElementType).Returns(query_users.ElementType);
            mock_users.As<IQueryable<Twit>>().Setup(m => m.GetEnumerator()).Returns(query_users.GetEnumerator());

            mock_context.Setup(c => c.TweeterUsers).Returns(mock_users.Object);
        }

        [TestMethod]
        public void RepoEnsureConCreateInstance()
        {
            repo = new TweeterRepository();
            Assert.IsNotNull(repo);
        }
    }
}
