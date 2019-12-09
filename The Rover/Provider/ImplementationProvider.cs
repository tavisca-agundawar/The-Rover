using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace The_Rover
{
    public static class ImplementationProvider
    {
        public static Rover GetRoverInstance(string initDetails)
        {
            var details = initDetails.Split(',');
            details = CleanDetails(details);
            if (details is null)
            {
                Console.WriteLine("Invalid initialization string!");
                return null;
            }
            try
            {
                var position = new Coordinate
                {
                    X = Convert.ToInt32(details[0]),
                    Y = Convert.ToInt32(details[1]),
                };
                return new Rover
                {
                    Position = position,
                    Direction = details[2].ToCharArray()[0]
                };
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private static string[] CleanDetails(string[] details)
        {
            List<string> cleanDetails = new List<string>();
            for (int i = 0; i < details.Length; i++)
            {
                details[i] = details[i].Trim();
                details[i] = Regex.Replace(details[i] , @"\(|\)", "");
                if (details[i].All(char.IsDigit))
                {
                    cleanDetails.Add(details[i]);
                }
                else if (Directions.IsValidDirection(details[i]))
                {
                    details[i].ToUpperInvariant();
                    cleanDetails.Add(details[i]);
                }
            }
            if (cleanDetails.Count == 3)
            {
                return cleanDetails.ToArray();
            }
            else
            {
                return null;
            }
        }

        public static RoverService GetRoverService()
        {
            return new RoverService();
        }
    }
}
