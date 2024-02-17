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
                menuProcess.DisplayMainMenu();
                Console.Write("\nEnter your choice: ");

                String menu1Case = Console.ReadLine();
                switch (menu1Case)
                {

                    //Login process
                    case "1":
                        {
                            Console.WriteLine("Enter username: ");
                            String userInput = Console.ReadLine();
                            bool checkUser = menuProcess.CheckUser(userInput, fileProcess.GetArrayData(userFile));

                            //If user found, proceed to check password
                            if (checkUser)
                            {

                                bool checkPassword = menuProcess.CheckPassword(fileProcess.GetArrayData(userFile));

                                //If login success, proceed to user's menu
                                if (checkPassword)
                                {
                                    //Get user infomation and store in Array
                                    String[] userInfo = menuProcess.GetUserInfo(userInput);
                                    String charFile = $"{userInfo[0]}_char.txt";
                                    bool menu2 = true;

                                    //User's Menu
                                    while (menu2)
                                    {
                                        Console.WriteLine($"Welcome {userInfo[0]}\n");
                                        menuProcess.DisplayUserMenu();
                                        Console.Write("\nEnter your choice: ");
                                        String menu2Case = Console.ReadLine();
                                        switch (menu2Case)
                                        {

                                            //Display-Update User infomation
                                            case "1":
                                                {
                                                    
                                                    Console.WriteLine($"\nUsername: {userInfo[0]}");
                                                    Console.WriteLine($"Password: {userInfo[1]}");
                                                    Console.WriteLine($"Email:    {userInfo[2]}\n");
                                                   // Console.WriteLine($"Char File:    {charFile}\n");
                                                    menuProcess.DisplayUserInfoMenu();
                                                    Console.Write("\nEnter your choice: ");
                                                    String menuUserInfo = Console.ReadLine();
                                                    switch (menuUserInfo)
                                                    {
                                                        case "1":
                                                            {
                                                                break;
                                                            }
                                                        case "2":
                                                            {
                                                                break;
                                                            }
                                                        case "3":
                                                            {
                                                                break;
                                                            }
                                                    }

                                                    break;
                                                }

                                            //Create Character
                                            case "2":
                                                {
                                                    break;
                                                }

                                            //Display Character
                                            case "3":
                                                {
                                                    break;
                                                }

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

                            //If user not found when log in, return to Main Menu
                            else
                            {
                                Console.WriteLine("User not found.\n");
                            }

                            break;
                        }

                    //Create user process
                    case "2":
                        {
                            menuProcess.CreateUser(userFile, fileProcess.GetArrayData(userFile));
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
