using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEDU.Areas.Staff.Models;

namespace TEDU.Areas.Staff.Controllers
{
    public class NewsController : Controller
    {
        // GET: Admin/News
        public ActionResult Index()
        {
            ViewBag.PageType = "News";
            ViewBag.Data = new List<News>
            {
                new News { NewsId = 01,STT = 1 ,Title = "Xe khách 2TL mở chi nhánh tại thành phố Mumbai, Ấn Độ" , Img = @"~/Assets/Admin/img/anh1.jpg", Meta = "chi-nhanh-moi", hide = true,  PublishedDate = new DateTime(2024,9,18,20,6,32) },
                new News { NewsId = 01,STT = 2 ,Title = "Xe khách 2TL mở chi nhánh tại thành phố Dubai, UAE" , Img = @"~/Assets/Admin/img/anh2.jpg", Meta = "chi-nhanh-moi", hide = false,  PublishedDate = new DateTime(2023,2,18,20,6,32) },
                new News { NewsId = 01,STT = 3 ,Title = "Xe khách 2TL mở chi nhánh tại thành phố Paris, Pháp" , Img = @"~/Assets/Admin/img/anh3.jpg", Meta = "chi-nhanh-moi", hide = true,  PublishedDate = new DateTime(2022,12,18,20,6,32) },
                new News { NewsId = 01,STT = 4 ,Title = "Xe khách 2TL mở chi nhánh tại thành phố California, USA" , Img = @"~/Assets/Admin/img/anh4.jpg", Meta = "chi-nhanh-moi", hide = false,  PublishedDate = new DateTime(2021,9,1,20,6,32) },

            };
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}