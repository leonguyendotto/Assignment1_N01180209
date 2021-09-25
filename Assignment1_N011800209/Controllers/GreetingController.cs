using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N011800209.Controllers
{
    public class GreetingController : ApiController
    {
        ///<summary>
        ///Returns the string Hello World! 
        ///<example> GET api/Greeting </example>
        ///</summary>
        ///<param name="id">The input to number of people</param>
        ///<returns> The input string to "Greeting to + id + people" </returns>
        public string Get (int id)
        {
            return "Greeting to " + id + " people";
        }

    }
}
