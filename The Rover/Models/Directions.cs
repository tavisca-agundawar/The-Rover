using System;
using System.Collections.Generic;
using System.Text;

namespace The_Rover
{
    public static class Directions
    {
        private static readonly List<char> directions;
        static Directions()
        {
            directions = new List<char> { 'N', 'E', 'S', 'W' };
        }
        public static char TurnLeft(char currentDir)
        {
            var pos = directions.IndexOf(currentDir);
            if (pos == 0)
            {
                return directions[directions.Count - 1];
            }
            else
            {
                return directions[pos - 1];
            }
        }
        public static char TurnRight(char currentDir)
        {
            var pos = directions.IndexOf(currentDir);
            if (pos == (directions.Count - 1))
            {
                return directions[0];
            }
            else
            {
                return directions[pos + 1];
            }
        }

        public static bool IsValidDirection(string dir)
        {
            var dirChar = dir.ToCharArray()[0];
            if (directions.Contains(dirChar))
            {
                return true;
            }
            return false;
        }
    }
}
