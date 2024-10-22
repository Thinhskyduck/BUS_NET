using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEDU.Areas.Admin.Controllers
{
    public class TripController : Controller
    {
        // GET: Admin/Trip
        public ActionResult Index()
        {
            return View();
        }
    }
}