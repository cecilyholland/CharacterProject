using CPCS3130_Project;

namespace CPSC3130_Project
{
	//This class for the Menus process
	//Provides Display all Menus
	//Provides Check User, Check Password, Create User, Get User Infomation.
	//Provides Create Character, Display Character Infomation
	public class MenuProcess
	{
		int _userID = 0;		//user ID - the arrayID of user in array
		String _userName = "";
        FileProcess _fileProcess = new FileProcess();
        public MenuProcess()
		{
		}

		//Get UserName
		public String getUserName()
		{
			return _userName;
		}

		//Main Menu
		public void DisplayMainMenu()
		{
            Console.WriteLine("Welcome to ***-Underdark Knights-***");
            Console.WriteLine("1. Login ");
            Console.WriteLine("2. Create Account ");
            Console.WriteLine("3. Exit ");
        }

		//User Menu
		public void DisplayUserMenu()
		{
            Console.WriteLine("1. Update account infomation ");
            Console.WriteLine("2. Create new Character ");
            Console.WriteLine("3. Display Character ");
            Console.WriteLine("4. Log out ");
            Console.WriteLine("5: Exit ");
        }

		//User Infomation Menu
		public void DisplayUserInfoMenu()
		{
            Console.WriteLine("1. Change password: ");
            Console.WriteLine("2. Change email: ");
            Console.WriteLine("3. Exit:\n ");
        }

        //Method check user. Return true if user is found.
        public bool CheckUser(String userInput, List<String[]> arrayData)
		{
			bool userCheck = false;
			for (int i = 0; i < arrayData.Count; i++)
			{
				if (userInput.Equals(arrayData[i][0]))
				{
					this._userID = i;
					_userName = arrayData[i][0];
					userCheck = true;
				}
				
			}
			return userCheck;
		}

		//Method check password. Return True if password match in 5 times
		public bool CheckPassword(List<String[]> arrayData)
		{
			bool passwordCheck = false;
			for (int count =4; count > -1; count --)
			{
                Console.Write("Passwords: ");
                String passwordInput = Console.ReadLine();
                if (passwordInput.Equals(arrayData[this._userID][1]))
				{
					Console.WriteLine("Login success.\n");
					passwordCheck = true;
					break;
				}
				else
				{
                    Console.WriteLine($"\nWrong password for user {arrayData[this._userID][0]}.");
					if (count == 0)
					{
						Console.WriteLine($"Sorry!!! - Return to Main Menu\n");
					}
					else
					{
						Console.WriteLine($"You have {count} attempt left.\n");
					}
				}
			}
			return passwordCheck;
		}

		//Method create user - init object from Account class and use its methods
		public void CreateUser(String file, List<String[]> arrayData)
		{
			String[] userInfo = new String[3];

			List<String[]> userData = new List<String[]>();

			Account account = new Account();

			bool userExist = true;

			//Call create user method from Account Class
			while (userExist == true)
			{
				account.CreateUsername();

                //Call CheckUser method to check if username exist or not.
                userExist = this.CheckUser(account.GetUsername(), arrayData);
				if (userExist == true)
				{
					Console.WriteLine($"User {account.GetUsername()} exist. Get another username.\n");
				}
			}

            //Call create password and email methods from Account Class
            account.CreatePassword();
			account.CreateEmail();

			//Add values to Array
			userInfo[0] = account.GetUsername();
			userInfo[1] = account.GetPassword();
			userInfo[2] = account.GetEmail();

			//Add array values to List
			userData.Add(userInfo);

			//Create FileProcess instance object and write user info to file
			//FileProcess fileProcess = new FileProcess();
            _fileProcess.WriteFile(userData, file);
			Console.WriteLine($"User created.\n");
		}

		//Method get user infomation. Return userinfo in array
        public String[] GetUserInfo(String user)
        {
            String[] userInfo = new string[3];
			String file = "UserData.txt";
			List<String[]> arrayData = _fileProcess.GetArrayData(file);

            for (int i = 0; i < arrayData.Count; i++)
			{
				if (user.Equals(arrayData[i][0]))
				{
					userInfo[0] = arrayData[i][0];
                    userInfo[1] = arrayData[i][1];
                    userInfo[2] = arrayData[i][2];
					break;
                }
			}			
			return userInfo;
        }
     
        //Method Create Character - Create CharacterCreate instance object.
        public void CreateCharacter(String fileName)
        {
			List<String[]> charData = new List<string[]> { };

		
            Character character = new Character();

            //Add data to Array and write to a file under "{username}_Character" name
            character.DisplayCharacter();
            charData.Add(character.GetName());
            charData.Add(character.GetGender());
            charData.Add(character.GetAlignment());
            charData.Add(character.GetRace());
            charData.Add(character.GetAge());
            charData.Add(character.GetWeight());
            charData.Add(character.GetHeight());
            _fileProcess.WriteFile(charData, fileName);
		}

		//Method to Display Character infomation.
		public void DisplayCharacter(String fileName)
		{

				//Read Character file and store in charInfo array
                List<String[]> charInfo = _fileProcess.GetCharData(fileName);
            Console.WriteLine("\n    *** Character Infomation ***");
				//Display array
                for (int i = 0; i < charInfo.Count; i++)
				{
					for (int j = 0; j < charInfo[i].Length; j++)
					{
						if (j == charInfo[i].Length - 1)
						{
							Console.Write($":\t{charInfo[i][j]}\n");
						}
						else
						{
							Console.Write($"{charInfo[i][j]}     \t ");
						}
					}
				}	
			Console.WriteLine();
        }
    }
}
