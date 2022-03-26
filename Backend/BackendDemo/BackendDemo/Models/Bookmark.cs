﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BackendDemo.Models
{
    public class BookmarkContext : DbContext
    {
        public DbSet<Bookmark> Bookmarks { get; set; }
    }
    [Table("Bookmark")]
    public class Bookmark
    {
        [Required] [Key]
        public string SerNo { get; set; }
        public string Name { get; set; }
        public string FBUrl { get; set; }

    }

    
}