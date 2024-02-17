
//using System.Reflection.PortableExecutable;

using CPSC3130_Project;

namespace CPCS3130_Project
{
    //Main Class to implement Menus
    internal class Menu
    {
        public static void Main(String[] args)
        {

            //Creat FileProcess and MenuProcess intance Objects
            FileProcess fileProcess = new FileProcess();
            MenuProcess menuProcess = new MenuProcess();

            //Set the filename to save the user infomation.
            String userFile = "UserData.txt";
            bool menu1 = true;

            //Main Menu
            while (menu1)
            {
                Console.WriteLine("Welcome to ***-Underdark Knights-***");
                Console.WriteLine("1. Login ");
                Console.WriteLine("2. Create Account ");
                Console.WriteLine("3. Exit ");
                Console.Write("\nEnter your choice: ");

                String menu1Case = Console.ReadLine();
                switch (menu1Case)
                {

                    //Login process
                    case "1":
                        {
                            Console.WriteLine("Enter username: ");
                            String userInput = Console.ReadLine();
                            bool checkUser = menuProcess.CheckUser(userInput, fileProcess.ReadFile(userFile));

                            //If user found, proceed to check password
                            if (checkUser)
                            {

                                bool checkPassword = menuProcess.CheckPassword(fileProcess.ReadFile(userFile));

                                //If login success, proceed to user's menu
                                if (checkPassword)
                                {
                                    bool menu2 = true;

                                    //User's Menu
                                    while (menu2)
                                    {
                                        Console.WriteLine($"Welcome {userInput}\n");
                                        Console.WriteLine("1. Update account infomation: ");
                                        Console.WriteLine("2. Create new Character: ");
                                        Console.WriteLine("3. Display Character: ");
                                        Console.WriteLine("4. Log out ");
                                        Console.WriteLine("5: Exit ");
                                        Console.Write("\nEnter your choice: ");
                                        String menu2Case = Console.ReadLine();
                                        switch (menu2Case)
                                        {

                                            //Logout - Return to Main Menu
                                            case "4":
                                                {
                                                    menu2 = false;
                                                    Console.WriteLine("Logout successful!\n");
                                                    break;
                                                }

                                            //Exit - End
                                            case "5":
                                                {
                                                    menu1 = false;
                                                    menu2 = false;
                                                    Console.WriteLine("\nGoodbye!");
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("Please input between 1-5!\n");
                                                    break;
                                                }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("User not found. Goobye.");

                            }

                            break;
                        }

                    //Create user process
                    case "2":
                        {
                            menuProcess.CreateUser(userFile, fileProcess.ReadFile(userFile));
                            break;
                        }
                    //Exit - End
                    case "3":
                        {
                            Console.WriteLine("\nGoobye!");
                            menu1 = false;
                            break;
                        }
                    //If choose the wrong option - Return to main menu.
                    default:
                        {
                            Console.WriteLine("Please input between 1-3!\n");
                            break;
                        }
                }
            }
        }

    }
}