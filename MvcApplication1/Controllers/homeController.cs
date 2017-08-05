using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            Infolist i = new Infolist();


            return View(i.Accounts);


        }

        public ActionResult addv()
        { 
        return View();
        
        }
        public ActionResult save(Account acc) 
        {

            return View();
        
        }

    }
}
