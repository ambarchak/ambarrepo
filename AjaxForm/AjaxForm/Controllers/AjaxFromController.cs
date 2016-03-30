using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxForm.Controllers
{
    public class AjaxFromController : Controller
    {
        //
        // GET: /AjaxFrom/

        public ActionResult AjaxFrom()
        {
            AjaxClass cls = new AjaxClass();
            cls.str = "";
    
            return View();
        }
        [HttpPost]
        public ActionResult AjaxFrom(AjaxClass obj)
        {
        //  ViewBag.Title = "ajax";
            return Content("ajax"+obj .chkval .ToString ()) ;
        }
    }
}
