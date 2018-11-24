using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ComicBookGallery.Models
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek== DayOfWeek.Monday)
            {
                return Redirect("/"); //"/" represents the root of the website
            }
            return Content("Hello from the comic books controller!");
            
              
            
            
            
            
        }
    }
}