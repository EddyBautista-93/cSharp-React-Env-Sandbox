using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace VisualStudioReact.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my deault action";
        }
        // grabs the key of name and the value set anf the numTImes to the value
        //at the moment it is put in the url for the demo purpose of this exercise 
        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
    }
}