using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Blog.Controllers
{
    public class PostsController:Controller
    {
        public ActionResult index()
        {
            return Content("hello baby");
        }
    }
}