using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }

        public ActionResult myprofile()
        {
            if (System.Web.HttpContext.Current.Session["user"] != null)
            {
                if ((bool)Session["user"])
                {
                    //trường hợp đã login rồi

                    return View();
                }
            }
            return RedirectToAction("DangNhap", "TaiKhoan");
        }

        public ActionResult edit()
        {
            if (System.Web.HttpContext.Current.Session["user"] != null)
            {
                if ((bool)Session["user"])
                {
                    //trường hợp đã login rồi

                    return View();
                }
            }
            return RedirectToAction("DangNhap", "TaiKhoan");
        }

        public ActionResult create()
        {
            if (System.Web.HttpContext.Current.Session["user"] != null)
            {
                if ((bool)Session["user"])
                {
                    //trường hợp đã login rồi

                    return View();
                }
            }
            return RedirectToAction("DangNhap", "TaiKhoan");
        }

        public ActionResult single_post()
        {
            return View();
        }

    }
}