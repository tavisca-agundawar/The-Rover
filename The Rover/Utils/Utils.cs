using System;
using System.Collections.Generic;
using System.Text;

namespace The_Rover
{
    public class Utils
    {
        public static string GetInputFromUser(string message)
        {
            string value;
            while (true)
            {
                Console.WriteLine(message);
                value = Console.ReadLine();
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Value cannot be blank!");
                }
                else
                {
                    break;
                }
            }
            return value;
        }
    }
}
