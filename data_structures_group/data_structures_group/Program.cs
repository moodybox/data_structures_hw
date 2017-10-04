using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Assignment {
    class Program {

        public static Stack<String> myStack = new Stack<string>();
        public static Queue<String> myQueue = new Queue<string>();
        public static Dictionary<int, String> myDict = new Dictionary<int, string>();

        public static void add_one(String sStructure) {
            String userInput = "";

            Console.WriteLine("Enter a string to insert into the " + sStructure + ": ");
            userInput = Console.ReadLine();

            if (sStructure == "Queue") {
                myQueue.Enqueue(userInput);
            } else if (sStructure == "Stack") {
                myStack.Push(userInput);
            } else if (sStructure == "Dictionary") {
                Random rRand = new Random();
                myDict.Add(rRand.Next(), userInput);
            }
        }

        public static void add_huge(String sStructure) {

            for (int i = 0; i < 2000; i++) {

                if (sStructure == "Queue") {
                    myQueue.Enqueue("New Entry " + i);
                } else if (sStructure == "Stack") {
                    myStack.Push("New Entry " + i);
                } else if (sStructure == "Dictionary") {
                    myDict.Add(i, "New Entry " + i);
                }
            }
        }

        public static void display_structure(String sStructure) {

            if (sStructure == "Queue") {
                foreach (String print_job in myQueue) {
                    Console.WriteLine(print_job);
                }
            } else if (sStructure == "Stack") {
                foreach (String plate in myStack) {
                    Console.WriteLine(plate);
                }
            } else if (sStructure == "Dictionary") {
                foreach (KeyValuePair<int, String> entry in myDict) {
                    Console.WriteLine(entry.Value);
                }
            }
        }

        public static void search_structure(String sStructure) {
            String userInput = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.Write("Enter the value you are searching for: ");
            userInput = Console.ReadLine();

            sw.Start();

            //Something with the stopwatch

            if (sStructure == "Queue") {
                if (myQueue.Contains(userInput)) {
                    Console.WriteLine(userInput + " is found");
                    sw.Stop();
                    //Something with the stopwatch
                } else {
                    Console.WriteLine(userInput + " is not found");
                    sw.Stop();
                }
            } else if (sStructure == "Stack") {
                if (myStack.Contains(userInput)) {
                    Console.WriteLine(userInput + " is found");
                    sw.Stop();
                    //Something with the stopwatch
                } else {
                    Console.WriteLine(userInput + " is not found");
                    sw.Stop();
                }
            } else if (sStructure == "Dictionary") {
                if (myDict.ContainsValue(userInput)) {
                    Console.WriteLine(userInput + " is found");
                    sw.Stop();
                    //Something with the stopwatch
                } else {
                    Console.WriteLine(userInput + " is not found");
                    sw.Stop();
                }
            }

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = sw.Elapsed;

            Console.WriteLine("ts: " + ts);

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("Time elapsed: " + Convert.ToString(ts));
        }

        public static void clear_structure(String sStructure) {

            if (sStructure == "Queue") {
                myQueue.Clear();
            } else if (sStructure == "Stack") {
                myStack.Clear();
            } else if (sStructure == "Dictionary") {
                myDict.Clear();
            }
        }

        static void Main(string[] args) {
            //Declare Variables
            String sUserInput;
            int iMenu = 0;
            int iSelection = 0;
            Boolean bMenu = true;
            Boolean bSubMenu = true;
            String sStructure = "";
            //Stack<String> myStack;
            //Queue<String> myQueue;
            //Dictionary<int, String> myDict;

            while (bMenu) {

                while (iMenu == 0) {
                    Console.WriteLine("1. Stack");
                    Console.WriteLine("2. Queue");
                    Console.WriteLine("3. Dictionary");
                    Console.WriteLine("4. Exit");

                    Console.Write("Select one of the above: ");

                    sUserInput = Console.ReadLine();

                    try {
                        iMenu = Convert.ToInt32(sUserInput);
                        bSubMenu = true;
                    } catch {
                        Console.WriteLine("Invalid input. Enter an integer from the menu.");
                        iMenu = 0;

                    }

                    Console.WriteLine("iMenu: " + iMenu);

                    if (iMenu > 4 || iMenu < 1) {
                        iMenu = 0;
                    }
                }

                switch (iMenu) {
                    case 1:
                        sStructure = "Stack";
                        break;
                    case 2:
                        sStructure = "Queue";
                        break;
                    case 3:
                        sStructure = "Dictionary";
                        break;
                    case 4:
                        sStructure = "none";
                        bMenu = false;
                        break;
                }

                while (bSubMenu) {
                    Console.WriteLine("1. Add one time to " + sStructure);
                    Console.WriteLine("2. Add Huge List of Items to " + sStructure);
                    Console.WriteLine("3. Display " + sStructure);
                    Console.WriteLine("4. Delete from " + sStructure);
                    Console.WriteLine("5. Clear " + sStructure);
                    Console.WriteLine("6. Search " + sStructure);
                    Console.WriteLine("7. Return to Main Menu");
                    Console.Write("Select one of the above: ");

                    sUserInput = Console.ReadLine();

                    try {
                        iSelection = Convert.ToInt32(sUserInput);
                    } catch {
                        Console.WriteLine("Invalid input. Input a valid integer selction from the menu.\n");
                    }

                    switch (iSelection) {
                        case 1:
                            add_one(sStructure);
                            break;
                        case 2:
                            add_huge(sStructure);
                            break;
                        case 3:
                            display_structure(sStructure);
                            break;
                        case 4:

                            break;
                        case 5:
                            clear_structure(sStructure);
                            break;
                        case 6:
                            search_structure(sStructure);
                            break;
                        case 7:
                            bSubMenu = false;
                            iMenu = 0;
                            break;
                    }

                }
            }
        }
    }
}
