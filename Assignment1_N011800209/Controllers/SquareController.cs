using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N011800209.Controllers
{
    public class SquareController : ApiController
    {
        ///<summary>
        ///Returns square 2 more than the integer input{id}
        ///<example> GET api/Square/{id} </example>
        ///</summary>
        ///<param name="id"> The input number </param>
        ///<returns> The input number id * id </returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
