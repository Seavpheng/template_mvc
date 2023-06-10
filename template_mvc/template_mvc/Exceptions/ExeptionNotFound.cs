using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace template_mvc.Exceptions
{
    public class ExeptionNotFound : Exception
    {
        public ExeptionNotFound(string msg) : base(msg) 
        {

        }
    }
}