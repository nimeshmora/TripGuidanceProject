using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveller.Models;

namespace Traveller.Controllers
{
    public class HomeController : Controller
    {

private TripGuiderEntities db = new TripGuiderEntities();
       
        public ActionResult Index(String name)
        {
            //Request.QueryString;
           // ViewBag.Name(name);
            String category = Request.QueryString["name"];
            if(category==null){
                return View(db.sites.ToList());

            }
            else { 
            return View(db.sites.Where(s => s.s_category==name).ToList());
            }
        }
        

        
        public String Places(String name)
        {
            String category = Request.QueryString["name"];
            return "Name"+ Request.QueryString["name"];
            //return View(db.sites.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}