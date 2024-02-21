// create username, password, and email.
//Write the code for input validation for login.

namespace CPSC3130_Project
{
    internal class Account
    {
        //instance variables
        private string? _username = "";
        private string? _password = "";
        private string? _email = "";

        //constructor
        public Account()
        {
        }
        //take in username with input validation 
        public void CreateUsername()
        {
            Console.WriteLine("Enter your username: ");
            _username = Console.ReadLine();
            SetUserName(_username);
        }
        public void CreatePassword()
        {
            //take in password
            Console.WriteLine("Enter your password, please ensure that it has at least 1 number\": ");
            _password = Console.ReadLine();
            if (_password.Any(char.IsDigit))
            {
                Console.WriteLine("Password Accepted");
                SetPassword(_password);
            }
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
        public void SetPassword(string _password)
        {
            this._password = _password;
        }
        public string GetPassword()
        {
            return _password;
        }
        public void SetEmail()
        {
            this._email = _email;
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
        
    }
}
