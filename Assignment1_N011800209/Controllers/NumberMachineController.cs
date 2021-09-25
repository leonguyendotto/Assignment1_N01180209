using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N011800209.Controllers
{
    public class NumberMachineController : ApiController
    {
        ///<summary>
        ///Returns a result after the mathematical operations input{id}
        ///<example> GET api/NumberMachine/{id} </example>
        ///</summary>
        ///<param name="id"> The input number </param>
        ///<returns> The results after input id </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 5, id - 5, id / 5, id * 5 };
        }
    }
    ///Request 10
    ///Response: 15, 5, 2, 50
    ///Request -5
    ///Response: 0, -10, -1, -25
    ///Request 30
    ///Response: 35. 25, 6, 150
}