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

        public static int mainMenu() {
            int choice = 0;
            bool isInt = false;

            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Dictionary");
            Console.WriteLine("4. Exit");
            Console.Write("Enter a number 1-4: ");

            while (!isInt) {
                try {
                    choice = Convert.ToInt32(Console.ReadLine());
                    isInt = true;
                }
                catch {
                    Console.Write("\nYou must enter an integer to continue: ");
                    isInt = false;
                }
            }
            Console.WriteLine();
            return choice;
        }
        public static int stackMenu() {
            int choice = 0;
            bool isInt = false;

            Console.WriteLine("1. Add one time to Stack");
            Console.WriteLine("2. Add Huge List of Items to Stack");
            Console.WriteLine("3. Display Stack");
            Console.WriteLine("4. Delete from Stack");
            Console.WriteLine("5. Clear Stack");
            Console.WriteLine("6. Search Stack");
            Console.WriteLine("7. Return to Main Menu");
            Console.Write("Enter a number 1-7: ");

            while (!isInt) {
                try {
                    choice = Convert.ToInt32(Console.ReadLine());
                    isInt = true;
                }
                catch {
                    Console.Write("\nYou must enter an integer to continue: ");
                    isInt = false;
                }
            }
            Console.WriteLine();
            return choice;
        }
        public static int queueMenu() {
            int choice = 0;
            bool isInt = false;

            Console.WriteLine("1. Add one time to Queue");
            Console.WriteLine("2. Add Huge List of Items to Queue");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Delete from Queue");
            Console.WriteLine("5. Clear Queue");
            Console.WriteLine("6. Search Queue");
            Console.WriteLine("7. Return to Main Menu");
            Console.Write("Enter a number 1-7: ");

            while (!isInt) {
                try {
                    choice = Convert.ToInt32(Console.ReadLine());
                    isInt = true;
                }
                catch {
                    Console.Write("\nYou must enter an integer to continue: ");
                    isInt = false;
                }
            }
            Console.WriteLine();
            return choice;
        }
        public static int dictMenu() {
            int choice = 0;
            bool isInt = false;

            Console.WriteLine("1. Add one item to Dictionary");
            Console.WriteLine("2. Add Huge List of Items to Dictionary");
            Console.WriteLine("3. Display Dictionary");
            Console.WriteLine("4. Delete from Dictionary");
            Console.WriteLine("5. Clear Dictionary");
            Console.WriteLine("6. Search Dictionary");
            Console.WriteLine("7. Return to Main Menu");
            Console.Write("Enter a number 1-4: ");

            while (!isInt) {
                try {
                    choice = Convert.ToInt32(Console.ReadLine());
                    isInt = true;
                }
                catch {
                    Console.Write("\nYou must enter an integer to continue: ");
                    isInt = false;
                }
            }
            Console.WriteLine();
            return choice;
        }

        static void Main(string[] args) {
            bool exit = false;
            int mainChoice = 0;
            int stackChoice = 0;
            int queueChoice = 0;
            int dictChoice = 0;
            int subChoice = 0;
            String sStructure = "";



            while (!exit) {
                mainChoice = mainMenu();
                switch(mainChoice) {
                    case 1:
                        subChoice = stackMenu();
                        sStructure = "Stack";
                        break;
                    case 2:
                        subChoice = queueMenu();
                        sStructure = "Queue";
                        break;
                    case 3:
                        subChoice = dictMenu();
                        sStructure = "Dictionary";
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        exit = false;
                        break;
                }

                switch (subChoice) {
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
                        break;
                }
            }

        }
    }
}
