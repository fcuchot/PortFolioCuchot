using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortFolioWeb.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KidInParkIdx()
        {
            return View("~/Views/Project/PFH/Kidinpark.cshtml");
        }
        public ActionResult Informing()
        {
            return View("~/Views/Project/PFH/Informing.cshtml");
        }
    }
}