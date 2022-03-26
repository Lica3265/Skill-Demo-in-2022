using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BackendDemo.Models
{
    public class BookmarkContext : DbContext
    {
        public BookmarkContext() : base("name=BookmarkContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Bookmark> Bookmarks { get; set; }
    }
}