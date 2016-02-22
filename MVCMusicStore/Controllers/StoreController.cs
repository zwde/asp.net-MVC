using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
          {
              new Genre{Name="Disco"},
              new Genre{Name="Jazz"},
              new Genre{Name="Rock"}
          };
            return View(genres);
        }

        //http://localhost:2586/Store/Browse?genre=here
        /*public string Browse(string genre)
        {
           string message = HttpUtility.HtmlEncode("Store.Browse Genre=" + genre);
            return message;
        }*/
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }
        public ActionResult test()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album" + id };
            return View(album);
        }
    }
}