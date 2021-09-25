using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N011800209.Controllers
{
    public class AddTenController : ApiController
    {
        ///<summary>
        ///Returns +10 more than the integer input{id}
        ///<example> GET api/AddTen/{id} </example>
        ///</summary>
        ///<param name="id"> The input number </param>
        ///<returns> The input number id +10 </returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
