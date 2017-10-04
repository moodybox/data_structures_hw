/*
    Authors: Peter Garrow, Chelsey Johnson, Mitchell Moody, Christopher Holmstead
    Date: 10/4/2017
    Description: 
        This program allows a user to enter values into 3 different data structures: a Queue, a Stack, and a Dictionary. 
        The user may add single values or a large amount of auto-generated values.
        The user may also delete single items or clear out the entire data structure. 
        The user may also search the data structure for a given value.
        The user may also display all of the data in a data structure. 
        The user is able to move from the main menu to the data structure sub-menus and back to the main menu.
        The user must be in the main menu to exit the program. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_group {
    class Program {

        //The Program's Data Structures are delcared here
        public static Stack<String> myStack = new Stack<string>();
        public static Queue<String> myQueue = new Queue<string>();
        public static Dictionary<int, String> myDict = new Dictionary<int, string>();

        //This function will add a single user-entered item to the user-selected data structure
        public static void add_one(String sStructure) {
            String userInput = "";

            Console.Write("Enter a string to insert into the " + sStructure + ": ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            //This if statement adds one item to the user-selected data structure
            if (sStructure == "Queue") {
                myQueue.Enqueue(userInput);
            } else if (sStructure == "Stack") {
                myStack.Push(userInput);
            } else if (sStructure == "Dictionary") {
                Random rRand = new Random();
                myDict.Add(rRand.Next(), userInput);
            }

            Console.WriteLine("'" + userInput + "' has been added to the " + sStructure);
            Console.WriteLine();
        }

        //This function will add a large amount of auto-generated items to the user selected data structure
        public static void add_huge(String sStructure) {
            int iCount = 0;
            if (sStructure == "Queue") {
                iCount = myQueue.Count();
            } else if (sStructure == "Stack") {
                iCount = myStack.Count();
            } else if (sStructure == "Dictionary") {
                iCount = myDict.Count();
            }

            for (int i = iCount; i < (iCount + 2000); i++) {

                //This if statement will add a large amount of items to the user-selected data structure
                if (sStructure == "Queue") {
                    myQueue.Enqueue("New Entry " + i);
                } else if (sStructure == "Stack") {
                    myStack.Push("New Entry " + i);
                } else if (sStructure == "Dictionary") {
                    myDict.Add(i, "New Entry " + i);
                }
            }

            Console.WriteLine("Huge list has been added to the " + sStructure);
            Console.WriteLine();
        }

        //This function will display all the items stored within the user-selected data structure
        public static void display_structure(String sStructure) {

            if (sStructure == "Queue") {
                if (myQueue.Count() > 0) {
                    foreach (String print_job in myQueue) {
                        Console.WriteLine(print_job);
                    }
                } else {
                    Console.WriteLine("No entries found. The Queue is empty.");
                }
            } else if (sStructure == "Stack") {
                if (myStack.Count() > 0) {
                    foreach (String plate in myStack) {
                        Console.WriteLine(plate);
                    }
                } else {
                    Console.WriteLine("No entries found. The Stack is empty.");
                }
            } else if (sStructure == "Dictionary") {
                if (myDict.Count() > 0) {
                    foreach (KeyValuePair<int, String> entry in myDict) {
                        Console.WriteLine(entry.Value);
                    }
                } else {
                    Console.WriteLine("No entries found. The Dictionary is empty.");
                }
            }
            Console.WriteLine();
        }

        //This function will search the user-selected data structure for the user-entered item
        public static void search_structure(String sStructure) {
            // Declare variables
            String userInput = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.Write("Enter the value you want to search for: ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            // Start the stopwatch
            sw.Start();

            //This if statement goes to the user-selected data structure and then searches the data structure for the user-selected item
            //The user is then notified if the searched for value was found or if it was not be found 
            if (sStructure == "Queue") {
                if (myQueue.Contains(userInput)) {
                    Console.WriteLine("'" + userInput + "'" + " is found.");
                    sw.Stop();
                    Console.WriteLine();
                } else {
                    Console.WriteLine("'" + userInput + "'" + " is not found.");
                    sw.Stop();
                    Console.WriteLine();
                }
            } else if (sStructure == "Stack") {
                if (myStack.Contains(userInput)) {
                    Console.WriteLine("'" + userInput + "'" + " is found.");
                    sw.Stop();
                    Console.WriteLine();
                } else {
                    Console.WriteLine("'" + userInput + "'" + " is not found.");
                    sw.Stop();
                    Console.WriteLine();
                }
            } else if (sStructure == "Dictionary") {
                if (myDict.ContainsValue(userInput)) {
                    Console.WriteLine("'" + userInput + "'" + " is found.");
                    sw.Stop();
                    Console.WriteLine();
                } else {
                    Console.WriteLine("'" + userInput + "'" + " is not found.");
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

            // The Time taken to search the data structure for the user-entered value is displayed
            Console.WriteLine("Time elapsed: " + Convert.ToString(ts));
            Console.WriteLine();
        }

        //This function clears out the user-selected data structure of all of its values 
        public static void clear_structure(String sStructure) {
            if (sStructure == "Queue") {
                myQueue.Clear();
                Console.WriteLine("The Queue has been cleared.");
            } else if (sStructure == "Stack") {
                myStack.Clear();
                Console.WriteLine("The Stack has been cleared.");
            } else if (sStructure == "Dictionary") {
                myDict.Clear();
                Console.WriteLine("The Dictionary has been cleared.");
            }

            Console.WriteLine();
        }

        //This function deletes the user's-entered value from the user-selected data structure
        public static void delete_value(String sStructure)
        {
            if (sStructure == "Queue")
            {
                Queue<string> tempQueue = new Queue<string>();
                Console.Write("Enter the value you want to delete: ");
                string deleteQueue = Console.ReadLine();
                Console.WriteLine();
                bool contains = myQueue.Contains(deleteQueue);
                if (contains == true)
                {
                    while (contains)
                    {
                        //Items in the Queue are removed and added to a temp Queue until the value that the user wants to be deleted is found
                        if (myQueue.Peek() != deleteQueue)
                        {
                            tempQueue.Enqueue(myQueue.Dequeue());
                            
                        }
                        else
                        {
                            myQueue.Dequeue();
                            contains = false;
                            Console.WriteLine("'" + deleteQueue + "'" + " has been deleted from the Queue.");
                        }
                    }
                    //To preserve the original queue's order the remaining values are removed and added to the temp queue
                    while (myQueue.Count() > 0)
                    {
                        tempQueue.Enqueue(myQueue.Dequeue());
                    }
                    //All values in the temp queue are then removed from the temp queue and added back into the original queue
                    while (tempQueue.Count() > 0)
                    {
                        myQueue.Enqueue(tempQueue.Dequeue());
                    }
                }
                else
                {
                    Console.WriteLine("'" + deleteQueue + "'" + " is not in the Queue.");
                }
            }
            else if (sStructure == "Stack")
            {
                Stack<string> tempStack = new Stack<string>();
                Console.Write("Enter the value you want to delete: ");
                string deleteStack = Console.ReadLine();
                Console.WriteLine();
                bool contains = myStack.Contains(deleteStack);
                if (contains == true)
                {
                    while (contains)
                    {
                        //Values are removed from the original stack and added to a temp stack until the value the user wants to delete is found and removed
                        if (myStack.Peek() != deleteStack)
                        {
                            tempStack.Push(myStack.Pop());
                            

                        }
                        else
                        {
                            myStack.Pop();
                            contains = false;
                            Console.WriteLine("'" + deleteStack + "'" + " has been deleted from the Stack.");
                        }
                    }
                    //The temp stack is then emptied back into the original stack
                    while (tempStack.Count() > 0)
                    {
                        myStack.Push(tempStack.Pop());
                    }
                }
                else
                {
                    Console.WriteLine("'" + deleteStack + "'" + " is not in the Stack.");
                }
            }
            else if (sStructure == "Dictionary")
            {
                Console.Write("Enter the value you want to delete: ");
                string deleteDict = Console.ReadLine();
                Console.WriteLine();
                if (myDict.ContainsValue(deleteDict))
                {
                    string myValue = myDict.FirstOrDefault(x => x.Value == "deleteDict").Value;
                    //The following code will find and delete all key value pairs whose values match the users inputed value
                    foreach (var item in myDict.Where(x => x.Value == deleteDict).ToList())
                    {
                        myDict.Remove(item.Key);
                        Console.WriteLine("'" + deleteDict + "'" + " has been deleted from the Dictionary.");
                    }
                }
                else
                {
                    Console.WriteLine("'" + deleteDict + "'" + " is not in the Dictionary.");
                }
            }

            Console.WriteLine();
        }

        //The Main program starts here
        static void Main(string[] args) {
            //Variables
            String sUserInput;
            int iMenu = 0; //Used to select the user-desired main menu item
            int iSelection = 0; //Used to select the user-desired sub-menu item
            Boolean bMenu = true; //Controls the main menu loop
            Boolean bSubMenu = true; //Controls the sub-menu loop
            String sStructure = ""; //Stores the type of the data structure the user wants to work with

            //Starts the main menu program loop
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
                //This is the start of the sub-menu - the sub menu is written only once but it changes to show the user-selected data structure through using the sStructure variable
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

                    //A Try catch to ensure a number is added
                    try {
                        iSelection = Convert.ToInt32(sUserInput);
                    } catch {
                        Console.WriteLine("Invalid input. Input a valid integer selction from the menu.\n");
                        Console.WriteLine();
                    }

                    //Switch statement that calls the user-selected function and passes the user-chosen data structure
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
