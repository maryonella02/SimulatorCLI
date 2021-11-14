using System;
using System.IO;

namespace SimulatorCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            SetWindowProperties();
            ShowBanner(30);

            while (true)
            {
                ShowCurrentDirectoryLine();
                var a = Console.ReadLine();
                switch (a)
                {
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "help":
                        ShowHelpResult();
                        break;
                    case "home":
                        Console.Clear();
                        ShowBanner(0);
                        break;
                    default:
                        Console.WriteLine("\nSystem was unable to recognize the following command. \nPlease enter a valid command or type 'help' to get the list of available commands.");
                        break;
                }
            }
        }
        static void SetWindowProperties()
        {
            Console.Title = "Lab 1 CLI simulator";
            Console.SetWindowSize(100, 40);
        }
        static void ShowBanner(int interval)
        {
            TypeLine("\t \t Welcome to the CLI simulator, " + Environment.UserName + "!", interval);
            TypeLine("\n\t Your current OS version is: " + Environment.OSVersion, interval);
            TypeLine("\n\t And it's running on machine: " + Environment.MachineName, interval);
            TypeLine("\n\nType 'help' + ENTER -- for available commands.", interval);
        }
        static void ShowCurrentDirectoryLine()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\n" + Environment.CommandLine + "> ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void ShowHelpResult()
        {
            Console.WriteLine("\nType [command] + ENTER \n");
            Console.WriteLine("'clear' -- clears the CLI simulator window");
            Console.WriteLine("'exit' -- closes the CLI simulator window");
            Console.WriteLine("'help' -- returns the list of available commands");
            Console.WriteLine("'home' -- returns to start");
        }
        static void TypeLine(string line, int interval)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(interval);
            }
        }
    }
}
