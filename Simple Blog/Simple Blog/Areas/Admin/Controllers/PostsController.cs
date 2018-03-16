using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Blog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        public ActionResult Index()
        {
            return Content("this is an admin Posts Controller Index");
        }
        public ActionResult clear()
        {
            return Content("this is an admin Posts Controller Clear");
        }
        public ActionResult update()
        {
            return Content("this is an admin Posts Controller update");
        }
    }
}