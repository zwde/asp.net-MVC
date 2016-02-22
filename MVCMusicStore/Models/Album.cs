using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCMusicStore.Models
{
    //专辑类
    public class Album
    {
        public string Title{get;set;}
        public Genre genre { get; set; }

    }
    public class AlbumDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}