using System;
using CPCS3130_Project;

namespace CPSC3130_Project
{
	//This class for the Menus process
	public class MenuProcess
	{
		int _userID = 0;		//user ID - the arrayID of user in array
		String _userName = "";	
		public MenuProcess()
		{
		}

		//Get UserName (not used yet)
		public String getUserName()
		{
			return _userName;
		}

		//Check user while log in. Return true if user is found.
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

		//Method check password when log in - Return True if password match in 5 times
		public bool CheckPassword(List<String[]> arrayData)
		{
			bool passwordCheck = false;
			for (int count =4; count > -1; count --)
			{
                Console.WriteLine("Passwords: ");
                String passwordInput = Console.ReadLine();
                if (passwordInput.Equals(arrayData[this._userID][1]))
				{
					Console.WriteLine("Login success.");
					passwordCheck = true;
					break;
				}
				else
				{
                    Console.WriteLine($"Wrong password for user {arrayData[this._userID][0]}.");
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

		//Method to create user - init object from Account class and use its methods
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
			FileProcess fileProcess = new FileProcess();
            fileProcess.WriteFile(userData, file);
			Console.WriteLine($"User created.\n");
		}
    }
}

