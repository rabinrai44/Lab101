using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab101
{
    class Program
    {
        static void Main(string[] args)
        {

            // initial message here

            // Message to the user entering first 3 digits number
            Console.Write("Enter the FirstNumber with 3 digits: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            // Message to the user entering first 3 digits number
            Console.Write("Enter the SecondNumber with 3 digits: ");
            int SecondNumebr = Convert.ToInt32(Console.ReadLine());

            // call the methods
            // Compare the given two different 3 digits numbers with the method called 'CompareInt' passing the parameter through FirstNumber and SecondNumber from user and print the message "True" or "False"
            Console.Write("Compared integers result: ");
            Console.Write(CompareInt(FirstNumber, SecondNumebr) ? "True" : "False");
            Console.Read();

        }

      



        //GetInteger
       // public static int GetInteger(string message)
        //{
            // do something crazy code
       // }

        // CompareInt
        public static bool CompareInt(int x, int y)
        {
            // do something amazing work here

            int LastDititX = x % 10;
            int LastDititY = y % 10;
            int sum1 = LastDititX + LastDititY;

            // do loops until y's value = 0;
            do
            {
                LastDititX = x % 10;
                LastDititY = y % 10;
                x = x / 10;
                y = y / 10;

                int sum2 = LastDititX + LastDititY;

                //check sum1 and sum2 is not equal, return false
                if (sum2 != sum1)
                {
                    return false;
                }

            } while (y != 0);

            return true;
        }
    }
}
