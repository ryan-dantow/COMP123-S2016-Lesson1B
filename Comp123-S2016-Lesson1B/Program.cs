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
 * Version 0.2 - Added GetUserName method
 */
namespace Comp123_S2016_Lesson1B
{
    class Program
    {
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
