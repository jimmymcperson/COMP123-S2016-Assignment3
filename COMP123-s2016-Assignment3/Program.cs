using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================================================================================
 * Author: Jonathan Hao
 * Student#: 300869273
 * Date Modified: June 16, 2016
 * Description: This is a demonstration of class diagrams, abstract classes/methods, and interfaces.
 * Version: 0.1.1 - Final product.
 * ==================================================================================================
 */
namespace COMP123_s2016_Assignment3
{

     /** <summary>
     * This is the "driver" class for our program.
     * </summary>
     * 
     * @class Program
     */
    public class Program
    {

        /** <summary>
         * This is the "main" method.
         * </summary>
         * 
         * @method Main
         * @param {string[]} args
         * @returns {void}
         */
        public static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Giant", 3000, 5000, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Terrestrial", 1000, 4000, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            waitForAnyKey();
        }


        /** <summary>
         * This method pauses the program until the user presses any key.
         * </summary>
         * 
         * @method waitForAnyKey
         * @returns {void}
         */
        public static void waitForAnyKey()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
