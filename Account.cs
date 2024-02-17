using System;
namespace CPCS3130_Project
{
	public class Account
    {
        //instance variables
        private string? _username = "";
        private string? _password = "";
        private string? _email = "";

        //StreamReader _cA = new StreamReader("Accounts");
        //StreamWriter write = new StreamWriter("Accounts");

        //constructor
        public Account()
        {
        }
        //take in username with input validation 
        public void CreateUsername()
        {

            Console.WriteLine("Enter a username that is between 8 and 10 digits, has at least 1 number");
            Console.WriteLine("Enter your username: ");
            _username = Console.ReadLine();
            if (_username.Length >= 8 && _username.Length <= 10)
            {
                if (_username.Any(char.IsDigit))
                {
                    Console.WriteLine("Username accepted.");
                    SetUserName(_username);
                }
            }
        }
        public void CreatePassword()
        {
            //take in password
            Console.WriteLine("Enter your password: ");
            _password = Console.ReadLine();
        }
        public void CreateEmail()
        {
            //take in email
            Console.WriteLine("Enter your email: ");
            _email = Console.ReadLine();
        }

        public void SetUserName(string _username)
        {
            this._username = _username;
        }
        //Getters
        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }

        public string GetEmail()
        {
            return _email;
        }

        //connect username, password, and email into account info
        public string newAccountCreation()
        {

            string accountInfo = ($"~{_username}~{_password}~{_email}~");
            return accountInfo;

        }
        public string DisplayUser()
        {
            string userInfo = ($"The username you entered is: {GetUsername()}" +
            $"\nThe password you entered is: {GetPassword()}" +
            $"\nThe email you entered is: {GetEmail()}");
            return userInfo;
        }

        //save user information in the Accounts txt file
        public void WriteToFile()
        {
            StreamWriter newAccount = new StreamWriter("Accounts");
            newAccount.WriteLine(newAccountCreation());
            newAccount.Close();
        }
        //prints all info from txt file - just for testing
        //public string CurrentAccounts()
        //{

        //    string currentAccounts = _cA.ReadToEnd();
        //    return currentAccounts;
        //}

        ////login validation
        //public bool Login()
        //{
        //    bool approved;
        //    if (GetUsername().Equals(_cA) && GetPassword().Equals(_cA))
        //    {
        //        approved = true;
        //    }
        //    else
        //    {
        //        approved = false;
        //    }
        //    return approved;
        //}

        //public string UpdateAccount()
        //{
        //    //take in users choice
        //    Console.WriteLine("Would you like to change your username, password, or email? Enter 1, 2, or 3 respectivley.");
        //    int change = Convert.ToInt32(Console.ReadLine());
        //    switch (change)
        //    {
        //        case 1:
        //            //change username
        //            if (GetUsername().Equals(_cA)) //needs more to clarify the comparison
        //            {
        //                Console.WriteLine("What would you like the new username to be?");
        //                string? newUserName = Console.ReadLine();
        //                write.Write(newUserName);
        //                _cA.Close();
        //            }
        //            break;
        //        case 2:
        //            //change password
        //            break;
        //        case 3:
        //            //change email
        //            break;
        //    }
        //    //print new account info
        //    string updatedInfo = $"{GetUsername}, {GetPassword}, and {GetEmail}";
        //    return updatedInfo;
        //}
    }
}


