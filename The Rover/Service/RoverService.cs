using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace The_Rover
{
    public class RoverService
    {
        public string GetInitializationString()
        {
            return Utils.GetInputFromUser("Enter initialization string: ");
        }

        public string GetCommandString()
        {
            return Utils.GetInputFromUser("Enter command string: ");
        }

        internal void RunRover(Rover rover, string command)
        {
            command = command.ToUpperInvariant();
            for (int i = 0; i < command.Length; i++)
            {
                if (!IsValidCommand(command[i]))
                {
                    Console.WriteLine("Invalid command symbol: " + command[i]);
                    continue;
                }
                ExecuteCommand(rover,command[i]);
            }
        }

        private void ExecuteCommand(Rover rover, char v)
        {
            switch (v)
            {
                case 'L':
                    {
                        rover.UpdateDirection('L');
                        break;
                    }
                case 'R':
                    {
                        rover.UpdateDirection('R');
                        break;
                    }
                case 'M':
                    {
                        rover.Move();
                        break;
                    }
                default:
                    break;
            }
        }

        private bool IsValidCommand(char v)
        {
            if (v == 'L' || v == 'R' || v == 'M')
            {
                return true;
            }
            return false;
        }
    }
}
