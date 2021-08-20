using SimpleApp1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Color color)
        {
            Models.Color? oldColor = Session["color"] as Models.Color?;
            if (oldColor != null)
            {
                Votes.ChangeVote(color, (Models.Color)oldColor);
            }
            else
            {
                Votes.RecordVote(color);
            }
            ViewBag.SelectedColor = Session["color"] = color;
            return View();
        }
    }
}
