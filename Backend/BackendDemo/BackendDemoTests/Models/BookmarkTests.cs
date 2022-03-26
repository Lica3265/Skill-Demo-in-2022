using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackendDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDemo.Models.Tests
{
    [TestClass()]
    public class BookmarkTests
    {
        [TestMethod()]
        public void DBinitTest()
        {
            using(var db = new BookmarkContext())
            {
                db.Bookmarks.Add(new Bookmark { SerNo ="003" , Name = "李峻安二號" });
                db.SaveChanges();
            }
            Assert.IsTrue(true);
        }
    }
}