using System;
using System.Collections.Generic;
using System.Text;

namespace The_Rover
{
    public static class RoverHelper
    {
        public static void Move(this Rover rover)
        {
            switch (rover.Direction)
            {
                case 'N':
                    {
                        rover.Position.Y += 1;
                        break;
                    }
                case 'S':
                    {
                        rover.Position.Y -= 1;
                        break;
                    }
                case 'E':
                    {
                        rover.Position.X += 1;
                        break;
                    }
                case 'W':
                    {
                        rover.Position.X -= 1;
                        break;
                    }
                default:
                    break;
            }
        }
        public static void UpdateDirection(this Rover rover, char turn)
        {
            
            switch (turn)
            {
                case 'L':
                    {
                        rover.Direction = Directions.TurnLeft(rover.Direction);
                        break;
                    }
                case 'R':
                    {
                        rover.Direction = Directions.TurnRight(rover.Direction);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
