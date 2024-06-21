using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    /// http://localhost:61745/
    /// <summary>
    /// returns a string that tells the user how many ways between two dice they can get the sum of 10.
    /// </summary>
    /// <example>GET api/J2/DiceGame/6/8 -> There are 5 ways to get the sum 10.</example>
    /// <example>GET api/J2/DiceGame/12/4 -> There are 4 ways to get the sum 10.</example>
    /// <example>GET api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10.</example>
    /// <example>GET api/J2/DiceGame/5/5  -> There are 1 way to get the sum 10.</example>
    /// <param name="m"">integer for sides of first dice</param>
    /// <param name="n"">integer for sides of second dice</param>
    /// <returns>There are X ways to get the sum of 10</returns>
    public class J2Controller : ApiController
    {
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m, int n)
        {
            //create a while loop that isolates one input and loops through the other to see if they add up to 10
            int temp = 1;
            int carry = 0;

            while (temp <= m)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i + temp == 10)
                    {
                        carry++;
                    }
                }
                temp++;
            }

            if (carry == 1)
            {
                return "There is 1 way to get the sum of 10";
            } 
            else
            {
                return "There are " + carry + " ways to get the sum of 10";
            }
        }
    }
}
