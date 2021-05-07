using System;
using System.IO;

namespace Task_4._1._Files
{
    class Program
    {
        static bool getDirectory(out DirectoryInfo dirinfo)
        {

            string path = @"D:\4task2"; 
            
            dirinfo = new DirectoryInfo(path);

            //if directory with input path doesn`t exists, user will be asked to create a new directory;
            if (!dirinfo.Exists)
            {
                Console.WriteLine("This directory does not exists!" + Environment.NewLine +
                    "Would you like to create directory with input path?");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "yes":
                        {
                            dirinfo = new DirectoryInfo(path);
                            dirinfo.Create();
                            break;
                        }
                    case "no":
                        {
                            return false;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong command! Type \"yes\" or \"no\"");
                            break;
                        }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string backupDirName = ".backup";
            DirectoryInfo di;

            bool isExists = getDirectory(out di);
            if (!isExists)
            {
                return;
            }
            Console.WriteLine(di.FullName);

            while (true)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Type '1' to choose \"Observer mode\";");
                Console.WriteLine("Type '2' to choose \"Undo changes mode\";");
                Console.WriteLine("Type 'exit' to stop the program.");
                Console.WriteLine("------------------------------------------");

                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("You chose \"Observer mode\".");
                            Console.WriteLine("------------------------------------------");

                            if (di.Exists)
                            {
                                var observer = new Observer(di, backupDirName);
                                observer.Start();
                                Console.WriteLine("Press enter to exit.");
                                Console.ReadLine();
                                observer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("Directory doesn`t exists" + Environment.NewLine +
                                    "Exitting program...");
                                return;
                            }

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You chose \"Undo changes mode\".");
                            Console.WriteLine("------------------------------------------");
                            RollBack.GetSnapShots(di.FullName, backupDirName);
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("Returning to the main menu...");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid command!");
                            break;
                        }
                }
            }

        }
    }
}
