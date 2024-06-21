using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        [Route("api/J3/BronzeCount/{participants}/{scores}")]
        [HttpPost]
        //Upon research I had found that in order for this method to work through a HTTP request I would need to make a backend endpoint to handle a post request,
        //then I would need to make a post request body containing the information on the number of participants and their scores.
        //Once that is done, I can set a route endpoint to obtain that information, input their contents into the method below, and proceed.
        //I would put the data into a JSON object and send that in order for the logic to parse the object and get the integers I would need.
        //<returns>

        public string BronzeCount(int participants, int scores)
        {
            //make an array that houses all scores
            int temp = 0;
            int[] scoresArr = new int[participants];

            while (temp <= participants)
            {
                scoresArr[temp] = scores;
                temp++;
            }

            //sort the array from lowest to highest then reverse the order
            Array.Sort(scoresArr);
            Array.Reverse(scoresArr);

            //Find the third highest score, then determine how many people got that score
            int bronze = scoresArr[2];
            int carry = 1;

            for (int i = 3; i < scoresArr.Length; i++)
            {
                if (scoresArr[i] == bronze) carry++;
            }

            //return answer as a string
            string foo = bronze.ToString();
            string bar = carry.ToString();

            return foo + " " + bar;
        }
    }
}
