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
            String charFile = "";
            String charAttFile = "";
            //Main Menu
            bool menu1 = true;
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
                            Console.Write("Enter username: ");
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
                                    charFile = $"{userInfo[0]}_Character.txt";
                                    charAttFile = $"{charFile}Att.txt";
                                    bool menu2 = true;

                                    //User's Menu
                                    while (menu2)
                                    {
                                        Console.WriteLine($"Welcome *** {userInfo[0]} ***\n");
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
                                            //End User's info Menu

                                            //Create Character
                                            case "2":
                                                {

                                                    //Check if user already had character. Create character deny
                                                    bool checkFile = File.Exists(charFile);
                                                    if (checkFile)
                                                    {
                                                        Console.WriteLine("You already have a character.");
                                                        Console.WriteLine("Choose 3 to Display your character infomation.\n");
                                                    }
                                                    else
                                                    {
                                                        //Call CreateCharacter method from MenuProcess                                                        
                                                        menuProcess.CreateCharacter(charFile);
                                                       
                                                    }
                                                    break;
                                                }

                                            //Display Character
                                            case "3":
                                                {

                                                    //Check if user have not created character yet. Ask to create one.
                                                    bool checkFile = File.Exists(charFile);
                                                    if (!checkFile)
                                                    {
                                                        Console.WriteLine("You have not created character yet.");
                                                        Console.WriteLine("Please choose 2 to create your character!\n");
                                                    }
                                                    else
                                                    {

                                                        //Call DisplayCharacter method from MenuProcess
                                                        menuProcess.DisplayCharacter(charFile);
                                                    }                                                
                                                    break;
                                                }

                                            //Logout - Return to Main Menu
                                            case "4":
                                                {
                                                    menu2 = false;
                                                    Console.WriteLine("Logout successful!\n");
                                                    break;
                                                }

                                            //Exit - End Program
                                            case "5":
                                                {
                                                    menu1 = false;
                                                    menu2 = false;
                                                    Console.WriteLine("\nGoodbye!");
                                                    break;
                                                }

                                            //If user input wrong.
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
                    //End of Login process.

                    //Create user process
                    case "2":
                        {
                            menuProcess.CreateUser(userFile, fileProcess.GetArrayData(userFile));
                            break;
                        }

                    //Exit - End Program
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
