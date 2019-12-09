using System;

namespace The_Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            RoverService service = ImplementationProvider.GetRoverService();
            while (!stop)
            {
                var initString = service.GetInitializationString();
                Rover rover = ImplementationProvider.GetRoverInstance(initString);
                if (rover != null)
                {
                    string command = service.GetCommandString();
                    service.RunRover(rover, command);
                    Console.WriteLine("Final position: ");
                    Console.WriteLine(rover.GetRoverDetails());
                }
                Console.WriteLine("");
                if (!IsConfirmed())
                {
                    stop = true;
                }
            }
        }

        private static bool IsConfirmed()
        {
            var choice = Utils.GetInputFromUser("Again ? : ");
            if (choice == "y" || choice == "Y")
            {
                return true;
            }
            return false;
        }
    }
}
