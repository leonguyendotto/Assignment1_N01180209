using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N011800209.Controllers
{
    public class InitativeController : ApiController
    {
        ///<summary>
        ///3 strings which describe the total hosting cost from input day{id}
        ///<example> GET api/Initative/{id} </example>
        ///</summary>
        ///<param name="id"> The input day </param>
        ///<returns> 3 strings which described total hosting cost </returns>
        public IEnumerable<string> Get(int id)
        {
            int numberOfFortnight = (id / 14) + 1;
            double subtotal = numberOfFortnight * 5.50;
            double tax = subtotal * 0.13;
            double total = subtotal + tax;
            string subtotalString = numberOfFortnight + " fortnights at $5.50/FN = $" + subtotal + " CAD";
            string taxString = "HST 13% = $" + tax + "CAD";
            string totalString = "Total= $" + total + "CAD";


            return new string[] { subtotalString, taxString, totalString };

        }
    }
    }
/// FN = 14 days 
/// $5.50/FN  , 5.50 = 14 days
/// 13%HST - on top of FN 
/// (id/14)+1 - number of 14-day periods
/// subtotal = FN * 5.50
/// tax = subtotal * 0.13 (13% = 0.13)
/// total = subtotal + tax
/// "double" variable stores floating point numbers, with decimals - according to W3Schools.com
/// The only thing I could not figure out was how to do the decimal (round) like your response
/// I want to do the regular return but do sentences keep stay at 1 line. As far as I research, I found "Environment.Newline" and \r\n but when I tried, it failed!
/// So I decided to use the arrayString to line break
/// This challenge was pretty fun and awesome

