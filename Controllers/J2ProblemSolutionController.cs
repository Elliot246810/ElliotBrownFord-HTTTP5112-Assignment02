using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J2ProblemSolutionController : ApiController
    {
        /// <summary>
        /// This gets the number of sides that the Dice have and See How many ways it adds up to 10
        /// </summary>
        /// <param name="m">The Number Of Sides On The First Dice</param>
        /// <param name="n">The Number Of Sides On The Second Dice</param>
        /// <returns>It returns the number of ways you can get 10 with the dices sides</returns>
        [Route("api/J2ProblemSolution/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {
            int counter = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int o = 1; o <= n; o++)
                {
                    if( i + o == 10)
                    {
                        counter++;
                    }

                }
            }
            return "There is " + counter + " ways to get the sum 10";
        }

    }
}
