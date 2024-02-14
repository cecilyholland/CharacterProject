
namespace AccountClass
{
    internal class AccountTester
    {
        static void Main(string[] args) {
            int userInput = 0;

            //object instantiation
            Account a = new Account();
            //cycles continuously until adequate input 
            while (true)
            {
                //display options for user
                Console.WriteLine("Hello, what would you like to do today?" +
                    "\n1.Login" +
                    "\n2.Create Account" +
                    "\n3.Update Account" +
                    "\n4. Exit ");
                //input validation catch 
                try
                {
                    //convert input to int 
                    userInput = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please choose one of the listed options by the number it is associated with.");
                }
            }
            //switch case decides which methods to call 
            switch (userInput)
            {
                case 1:
                    //login
                    a.Login();
                    
                    break;
                case 2:
                    //create new account
                    a.CreateUsername();
                    a.CreatePassword();
                    a.CreateEmail();
                    //prints input information
                    Console.WriteLine(a.DisplayUser());
                    //formats into linked format - only call when creating a new account
                    a.newAccountCreation();
                    //writes to txt file - only call when creating a new account
                    a.WriteToFile();
                    break;
                case 3:
                    //update user
                    a.UpdateAccount();
                    break;
                case 4: 
                    //exit
                    break;
            }
                
            //prints all info from txt file
            a.CurrentAccounts();


        }
    }
}
