using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace template_mvc
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public CustomRazorViewEngine() {
            ViewLocationFormats = new string[] {
                "~/Views/{1}/{0}.cshtml",
            };

            PartialViewLocationFormats = new string[]
            {
                "~/Shared/Views/{0}.cshtml"
            };
        }
    }
}