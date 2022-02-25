using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J1ProblemSolutionController : ApiController
    {
        /// <summary>
        /// This get the menu choices and return all the values of each one So they can be added up to a total
        /// </summary>
        /// <param name="burgerschoice">The Menu Choice When they choice a Burger Option</param>
        /// <param name="drinkchoice">The Menu Choice When they choice a Drink Option</param>
        /// <param name="sidechoice">The Menu Choice When they choice a Side Option</param>
        /// <param name="dessertchoice">The Menu Choice When they choice a Dessert Option</param>
        /// <returns>It returns the total number of calories of all of the menu choices together.</returns>
        [Route("api/J1ProblemSolution/Menu/{burgerschoice}/{drinkchoice}/{sidechoice}/{dessertchoice}")]
        public string GetMenu(int burgerschoice, int drinkchoice , int sidechoice , int dessertchoice)
        {
            int resultofburger = burgers(burgerschoice);
            int resultofdrink = drinks(drinkchoice);
            int resultofside = sides(sidechoice);
            int resultofdessert = desserts(dessertchoice);

            int totalresult = resultofburger + resultofdrink + resultofside + resultofdessert;
            string stringtotal = Convert.ToString(totalresult);
            string messages = "Your total calorie count is " + stringtotal;

            return messages;
        }


        public int burgers(int choice)
        {
            int caloriesreturned = 0;

            if(choice == 1)
            {
                caloriesreturned = 461;
            }
            else if(choice == 2)
            {
                caloriesreturned = 431;
            }
            else if(choice == 3)
            {
                caloriesreturned = 420;
            }
            else if(choice == 4)
            {
                caloriesreturned = 0;
            }
            return caloriesreturned;
        }
        public int drinks(int choice)
        {
            int caloriesreturned = 0;

            if (choice == 1)
            {
                caloriesreturned = 130;
            }
            else if (choice == 2)
            {
                caloriesreturned = 160;
            }
            else if (choice == 3)
            {
                caloriesreturned = 118;
            }
            else if (choice == 4)
            {
                caloriesreturned = 0;
            }
            return caloriesreturned;
        }
        public int sides(int choice)
        {
            int caloriesreturned = 0;

            if (choice == 1)
            {
                caloriesreturned = 100;
            }
            else if (choice == 2)
            {
                caloriesreturned = 57;
            }
            else if (choice == 3)
            {
                caloriesreturned = 70;
            }
            else if (choice == 4)
            {
                caloriesreturned = 0;
            }
            return caloriesreturned;
        }

        public int desserts(int choice)
        {
            int caloriesreturned = 0;

            if (choice == 1)
            {
                caloriesreturned = 167;
            }
            else if (choice == 2)
            {
                caloriesreturned = 266;
            }
            else if (choice == 3)
            {
                caloriesreturned = 75;
            }
            else if (choice == 4)
            {
                caloriesreturned = 0;
            }
            return caloriesreturned;
        }


    }
}
