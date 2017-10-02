using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_group {
    class Program {
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



            while (!exit) {
                mainChoice = mainMenu();
                switch(mainChoice) {
                    case 1:
                        stackChoice = stackMenu();

                        break;
                    case 2:
                        queueChoice = queueMenu();

                        break;
                    case 3:
                        dictChoice = dictMenu();

                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        exit = false;
                        break;
                }
            }

        }
    }
}
