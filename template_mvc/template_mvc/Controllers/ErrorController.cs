using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace template_mvc.Controllers
{
    public class ErrorController : Controller
    {
        // GET: CustomError
        [HandleError]
        public ActionResult NotFound()
        {
            var statusCode = (int)System.Net.HttpStatusCode.NotFound;
            Response.StatusCode = statusCode;
            Response.TrySkipIisCustomErrors = true;
            HttpContext.Response.StatusCode = statusCode;
            HttpContext.Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}