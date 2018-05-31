using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_commmerce.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult tables()
        {
            return View("tables");
        }
        public ActionResult forms()
        {
            return View("forms");
        }

        public ActionResult validation()
        {
            return View("validation");
        }

        public ActionResult charts()
        {
            return View("charts");
        }
        public ActionResult inbox()
        {
            return View("inbox");
        }
        public ActionResult compose()
        {
            return View("compose");
        }


    }
}
