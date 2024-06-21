using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// returns calorie count once user inputs thier selections
        /// </summary>
        /// <example> GET api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"</example>
        /// <example> GET api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"</example>
        /// <param name="burger">integer indicating which burger item</param>
        /// <param name="drink">integer indicating which drink item</param>
        /// <param name="side">integer indicating which side item</param>
        /// <param name="dessert">integer indicating which dessert item</param>
        /// <returns>"Your total calorie count is X"</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //create 4 arrays that house the constant calorie information for all inputs
            int[] burgerArr = { 461, 431, 420, 0 };
            int[] drinkArr = { 130, 160, 118, 0 };
            int[] sideArr = { 100, 57, 70, 0 };
            int[] dessertArr = { 167, 266, 75, 0 };

            //find the corresponding calories count
            int burgerChoice = burgerArr[burger - 1];
            int drinkChoice = drinkArr[drink - 1];
            int sideChoice = sideArr[side - 1];
            int dessertChoice = dessertArr[dessert - 1];

            //sum all the calories together then return
            int calories = burgerChoice + drinkChoice + sideChoice + dessertChoice;

            return "Your total calorie count is " + calories;
        }

    }
}
