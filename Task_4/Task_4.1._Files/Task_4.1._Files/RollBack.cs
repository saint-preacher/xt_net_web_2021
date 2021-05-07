using System;
using System.IO;
using System.Linq;

namespace Task_4._1._Files
{
    class RollBack
    {
        private static void PrintSnapshots(string[] snapshots, int headIndex, int tailIndex, int type = 0)
        {
            for (var i = headIndex - 1; i >= tailIndex; i--)
            {
                Console.WriteLine($"{i + 1}. {snapshots[i]}");
            }

            switch (type)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Input 'previous' to get the previous page.");
                        Console.WriteLine("Input 'next' to get the next page.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Input 'next' to get the next page.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Input 'previous' to get the previous page.");
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine("Type 'exit' to return to the main menu.");
            return;
        }

        private static int SelectSnapshot(int headIndex, int tailIndex, int type = 0)
        {
            var chosenOne = 0;

            while (chosenOne == 0 || (chosenOne < tailIndex + 1 || chosenOne > headIndex))
            {
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "next":
                        {
                            if (type == 1 || type == 2)
                            {
                                return -1;
                            }
                            break;
                        }
                    case "previous":
                        {
                            if (type == 1 || type == 3)
                            {
                                return -2;
                            }
                            break;
                        }
                    case "exit":
                        {
                            return 0;
                        }
                    default:
                        {
                            Int32.TryParse(choice, out chosenOne);
                            break;
                        };
                }
                if (chosenOne == 0 || (chosenOne < tailIndex + 1 || chosenOne > headIndex))
                {
                    Console.WriteLine("Choose valid snapshot");
                }
            }
            return chosenOne;
        }

        private static void RestoreSnapshot(string path, string backupDir, string chosenSnapshot)
        {
            var di = new DirectoryInfo(path).GetDirectories().Where(s => s.Name != backupDir);

            var snapshotToRestore = new DirectoryInfo(path + "\\" + backupDir + "\\" + chosenSnapshot);

            if (!snapshotToRestore.Exists) return;

            var filesToRestore = snapshotToRestore.EnumerateFiles("", SearchOption.AllDirectories);

            foreach (var directory in di)
            {
                directory.Delete(true);
            }

            foreach (var file in filesToRestore)
            {
                var newPath = path + "\\" + file.FullName.Substring(snapshotToRestore.FullName.Length + 1);


                Directory.CreateDirectory(new FileInfo(newPath).DirectoryName);
                file.CopyTo(newPath);
            }
        }
        public static void GetSnapShots(string path, string backupDir)
        {
            string[] snapshots = Directory.GetDirectories(path + "\\" + backupDir).ToList().Select(s => s.Substring(s.LastIndexOf("\\") + 1)).ToArray();
            //foreach (var snap in snapshots)
            //{
            //    Console.WriteLine(snap);
            //}
            if (snapshots.Length == 0)
            {
                Console.WriteLine("There are no avaliable snapshots!" + Environment.NewLine + "Returning to the main menu...");
                return;
            }

            Console.WriteLine("Available snapshots: ");

            if (snapshots.Length <= 20)
            {
                PrintSnapshots(snapshots, snapshots.Length, 0);

                Console.Write("Choose snapshot: ");

                int selection = SelectSnapshot(snapshots.Length, 0);

                if (selection == 0)
                {
                    return;
                }
                Console.WriteLine($"You chose {snapshots[selection - 1]} snapshot" + Environment.NewLine +
                                "Restoring directory...");
                RestoreSnapshot(path, backupDir, snapshots[selection - 1]);
                return;
            }
            else if (snapshots.Length > 20)
            {
                var headIndex = snapshots.Length;
                var tailIndex = snapshots.Length - 20;

                while (true)
                {
                    int type = 0;
                    if (headIndex == snapshots.Length && tailIndex == 0)
                    {
                        type = 0; // unable to get the next and the previous sets of snapshots 
                    }
                    else if (headIndex != snapshots.Length && tailIndex != 0)
                    {
                        type = 1; // able to get both sets of snapshots
                    }
                    else if (headIndex == snapshots.Length && tailIndex != 0)
                    {
                        type = 2; // able to to get only the next set of snapshots
                    }
                    else if (headIndex != snapshots.Length && tailIndex == 0)
                    {
                        type = 3; // able to to get only the previous set of snapshots
                    }
                    PrintSnapshots(snapshots, headIndex, tailIndex, type);
                    Console.Write("Choose snapshot: ");

                    // if selection == 0 then program returns to the main menu.
                    // if selection > 0 then user is about to choose from the current set of snapshots
                    // if selection == -1 then user is about to choose from the next set of snapshots
                    // if selection == -2 then user is about to choose from the previous set of snapshots
                    int selection = SelectSnapshot(headIndex, tailIndex, type);

                    switch (selection)
                    {
                        case 0:
                            {
                                return;
                            }
                        case -1:
                            {
                                headIndex = tailIndex;
                                tailIndex = tailIndex - 20;
                                if (tailIndex < 0)
                                {
                                    tailIndex = 0;
                                }
                                break;
                            }
                        case -2:
                            {
                                tailIndex = headIndex;
                                headIndex = tailIndex + 20;
                                if (headIndex > snapshots.Length)
                                {
                                    headIndex = snapshots.Length;
                                }
                                break;
                            }
                        default:
                            Console.WriteLine($"You chose {snapshots[selection - 1]} snapshot" + Environment.NewLine +
                                "Restoring directory...");

                            RestoreSnapshot(path, backupDir, snapshots[selection - 1]);
                            return;
                    }
                }
            }
        }
    }
}
