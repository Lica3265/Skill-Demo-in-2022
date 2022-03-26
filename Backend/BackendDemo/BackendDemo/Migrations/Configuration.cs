namespace BackendDemo.Migrations
{
    using BackendDemo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BackendDemo.Models.BookmarkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BackendDemo.Models.BookmarkContext context)
        {
            context.Bookmarks.AddOrUpdate(x => x.SerNo, new Bookmark() { SerNo = "001", Name = "李峻安", FBUrl = "秘密" });  
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

        }
    }
}
