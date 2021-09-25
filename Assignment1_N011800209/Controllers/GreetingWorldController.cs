using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N011800209.Controllers
{
    public class GreetingWorldController : ApiController
    {
        ///<summary>
        ///Returns the string Hello World! from prompt
        ///<example> POST api/GreetingWorld </example>
        ///</summary>
        ///<returns> The string to "Hello World!" </returns>
        public string Post() 
        {
            return "Hello World!";
        }
    }
}
