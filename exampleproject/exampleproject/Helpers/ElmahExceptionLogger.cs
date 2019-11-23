using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace exampleproject.Helpers
{
   
        public class ElmahExceptionLogger : ExceptionLogger
        {
            public override void Log(ExceptionLoggerContext context)
            {
                Trace.WriteLine(
                string.Format("{0},{1}",
                              DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),

                              context.ExceptionContext.Exception.ToString()));

            }
        }
    
}