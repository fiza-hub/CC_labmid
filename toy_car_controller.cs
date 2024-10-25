using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RemoteCarController
{
    class Program
    {
        // Define valid commands based on the grammar
        private static HashSet<string> validCommands = new HashSet<string>
        {
            "Start",
            "Stop",
            "Accelerate",
            "Brake",
            "Right"
            // Note: "Left" is included for context but is invalid for the car
        };

        public static void Main(string[] args)
        {
            // User input command
            Console.WriteLine("Enter a command for the remote car (Start, Stop, Accelerate, Brake, Right, Left):");
            string inputCommand = Console.ReadLine();

            // Check if the command is valid using both methods
            if (IsValidCommand(inputCommand))
            {
                if (inputCommand.Equals("Left", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Error: The car cannot turn left.");
                }
                else
                {
                    Console.WriteLine($"Command '{inputCommand}' executed successfully.");
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Please enter a valid command.");
            }

            // Define an array of commands to test
            string[] commands = { "Start", "Accelerate", "Right", "Left", "Stop", "Brake" };

            // Validate predefined commands using regex
            Console.WriteLine("\nTesting predefined commands:");
            foreach (var command in commands)
            {
                if (ParseCommand(command))
                    Console.WriteLine($"'{command}' is a valid command.");
                else
                    Console.WriteLine($"'{command}' is NOT a valid command. (Left turn is not supported.)");
            }
        }

        static bool IsValidCommand(string command)
        {
            return validCommands.Contains(command);
        }

        public static bool ParseCommand(string command)
        {
            // Regular expression pattern for valid commands
            string pattern = @"^(Start|Stop|Accelerate|Brake|Right)$";

            // Check if command matches any valid terminal
            return Regex.IsMatch(command, pattern);
        }
    }
}
