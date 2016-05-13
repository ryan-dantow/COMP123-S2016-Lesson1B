using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Ryan Dantow
 * Date: May 13th 2016
 * Studnet ID: 300775845
 * 
 * Description: this program demonstrates GitHub and version control
 * best practices. We also explore unit testing
 * 
 * Version 0.3 - Updated comments for driver class Program
 */
namespace Comp123_S2016_Lesson1B
{
    /**
     * This is the driver class for our program
     * 
     * @class Program
     */
    class Program
    {
        /**
         * Main Method for class Program
         * 
         * @param {string[]} args
         * @constructor Main
         */ 
        static void Main(string[] args)
        {
            GetUserName();
            
        }


        /**
         * This method reads the Username from the Console
         * 
         * @method GetUserName
         * @return {string} UserName
         */
         
        public static string GetUserName()
        {
            // Initialize Variables
            string UserName = "";

            Console.Write("Enter UserName: ");
            UserName = Console.ReadLine();

            Console.WriteLine("/n==========================");
            Console.WriteLine("You Entered: " + UserName);

            return UserName;

        }

    }
}
