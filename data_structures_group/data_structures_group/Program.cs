using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_group {
    class Program {

        public static Stack<String> myStack = new Stack<string>();
        public static Queue<String> myQueue = new Queue<string>();
        public static Dictionary<int, String> myDict = new Dictionary<int, string>();

        public static void add_one(String sStructure) {
            String userInput = "";

            Console.Write("Enter a string to insert into the " + sStructure + ": ");
            userInput = Console.ReadLine();
            Console.WriteLine();

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
            Console.WriteLine();
        }

        public static void search_structure(String sStructure) {
            String userInput = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.Write("Enter the value you want to search for: ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            sw.Start();

            //Something with the stopwatch

            if (sStructure == "Queue") {
                if (myQueue.Contains(userInput)) {
                    Console.WriteLine(userInput + " is found");
                    sw.Stop();
                    Console.WriteLine();
                    //Something with the stopwatch
                } else {
                    Console.WriteLine(userInput + " is not found");
                    sw.Stop();
                    Console.WriteLine();
                }
            } else if (sStructure == "Stack") {
                if (myStack.Contains(userInput)) {
                    Console.WriteLine(userInput + " is found");
                    sw.Stop();
                    Console.WriteLine();
                    //Something with the stopwatch
                } else {
                    Console.WriteLine(userInput + " is not found");
                    sw.Stop();
                    Console.WriteLine();
                }
            } else if (sStructure == "Dictionary") {
                if (myDict.ContainsValue(userInput)) {
                    Console.WriteLine(userInput + " is found");
                    sw.Stop();
                    Console.WriteLine();
                    //Something with the stopwatch
                } else {
                    Console.WriteLine(userInput + " is not found");
                    sw.Stop();
                    Console.WriteLine();
                }
            }

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = sw.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("Time elapsed: " + Convert.ToString(ts));
            Console.WriteLine();
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

        public static void delete_value(String sStructure)
        {
            if (sStructure == "Queue")
            {
                Queue<string> tempQueue = new Queue<string>();
                Console.Write("Enter the string you want to search for: ");
                string deleteQueue = Console.ReadLine();
                Console.WriteLine();
                bool contains = myQueue.Contains(deleteQueue);
                if (contains == true)
                {
                    while (contains)
                    {
                        if (myQueue.Peek() != deleteQueue)
                        {
                            tempQueue.Enqueue(myQueue.Dequeue());
                        }
                        else
                        {
                            myQueue.Dequeue();
                            contains = false;
                        }
                    }
                    while (myQueue.Count() > 0)
                    {
                        tempQueue.Enqueue(myQueue.Dequeue());
                    }
                    while (tempQueue.Count() > 0)
                    {
                        myQueue.Enqueue(tempQueue.Dequeue());
                    }
                }
                else
                {
                    Console.WriteLine("This value is not in the queue");
                    Console.WriteLine();
                }
            }
            else if (sStructure == "Stack")
            {
                Stack<string> tempStack = new Stack<string>();
                Console.Write("Enter the string you want to search for: ");
                string deleteStack = Console.ReadLine();
                Console.WriteLine();
                bool contains = myStack.Contains(deleteStack);
                if (contains == true)
                {
                    while (contains)
                    {
                        if (myStack.Peek() != deleteStack)
                        {
                            tempStack.Push(myStack.Pop());
                        }
                        else
                        {
                            myStack.Pop();
                            contains = false;
                        }
                    }
                    while (tempStack.Count() > 0)
                    {
                        myStack.Push(tempStack.Pop());
                    }
                }
                else
                {
                    Console.WriteLine("This value is not in the stack");
                    Console.WriteLine();
                }
            }
            else if (sStructure == "Dictionary")
            {
                Console.WriteLine("What value do you want to delete?");
                string deleteDict = Console.ReadLine();
                Console.WriteLine();
                if (myDict.ContainsValue(deleteDict))
                {
                    string myValue = myDict.FirstOrDefault(x => x.Value == "deleteDict").Value;
                    //The following code will delete all key value pairs whose values match the users inputed value
                    foreach (var item in myDict.Where(x => x.Value == deleteDict).ToList())
                    {
                        myDict.Remove(item.Key);
                    }
                }
                else
                {
                    Console.WriteLine("This value is not in the dictionary");
                    Console.WriteLine();
                }
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

            while (bMenu) {
                //Main menu output and loop.
                while (iMenu == 0) {
                    Console.WriteLine("1. Stack");
                    Console.WriteLine("2. Queue");
                    Console.WriteLine("3. Dictionary");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine();

                    Console.Write("Select one of the above: ");

                    sUserInput = Console.ReadLine();
                    Console.WriteLine();
                    
                    //Try catch for strings and numbers that are not 1-4.
                    try {
                        iMenu = Convert.ToInt32(sUserInput);
                        bSubMenu = true;
                    } catch {
                        Console.WriteLine("Invalid input. Enter an integer from the menu.");
                        Console.WriteLine();
                        iMenu = 0;
                    }
                    if (iMenu > 4 || iMenu < 1) {
                        iMenu = 0;
                    }
                }
                //This selects the data structure to be used, which will format the menus later
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
                        bSubMenu = false;
                        break;
                }
                //Sub menu output
                while (bSubMenu) {
                    Console.WriteLine("1. Add one time to " + sStructure);
                    Console.WriteLine("2. Add Huge List of Items to " + sStructure);
                    Console.WriteLine("3. Display " + sStructure);
                    Console.WriteLine("4. Delete from " + sStructure);
                    Console.WriteLine("5. Clear " + sStructure);
                    Console.WriteLine("6. Search " + sStructure);
                    Console.WriteLine("7. Return to Main Menu");
                    Console.WriteLine();
                    Console.Write("Select one of the above: ");

                    sUserInput = Console.ReadLine();
                    Console.WriteLine();

                    //Another try catch to ensure a number is added
                    try {
                        iSelection = Convert.ToInt32(sUserInput);
                    } catch {
                        Console.WriteLine("Invalid input. Input a valid integer selction from the menu.\n");
                        Console.WriteLine();
                    }

                    //Switch statement which calls the correct function based on the chosen data structure
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
                            delete_value(sStructure);
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
