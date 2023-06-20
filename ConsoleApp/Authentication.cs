using BusinessModels;
using BusinessLayer;


namespace ConsoleApp
{
    /// <summary>
    /// this class contains methods for registration and login and forgot passwords which conects to the business layer
    /// </summary>
    public class Authentication
    {

        /// <summary>
        /// this method is for interacting with user for registration
        /// </summary>
        public void UserRegistration()
        {
            BLAuthentication bLAuth = new BLAuthentication();

            Validations validate = new Validations();

            Users user = new Users();

            while (true)
            {
                Console.Write(Literals.userName);
                user.userName = Console.ReadLine();
                
                if (user.userName == "return")
                {
                    return;
                }
                if (validate.IsUserNameValid(user.userName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Literals.inValid);
                }
            }

            while (true)
            {
                Console.Write(Literals.emailId);
                user.emailId = Console.ReadLine();
                if (user.emailId == "return")
                {
                    return;
                }
                if (validate.IsEmailIdValid(user.emailId))
                {

                    break;
                }
                else
                {
                    Console.WriteLine(Literals.inValid);
                }
            }


            while (true)
            {
                Console.Write(Literals.phoneNo);
                user.phoneNo = Console.ReadLine();
                if (user.phoneNo == "return")
                {
                    return;
                }
                if (validate.IsPhoneNoValid(user.phoneNo))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Literals.inValid);
                }
            }

            if (bLAuth.Register(user.emailId, user.phoneNo))
            {

                Console.WriteLine(Literals.alreadyExists);
                return;

            }

            while (true)
            {
                Console.Write(Literals.password);
                user.password = Console.ReadLine();
                if (user.password == "return")
                {
                    return;
                }
                if (validate.IsPasswordValid(user.password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Literals.inValid);
                }
            }

            while (true)
            {
                Console.Write(Literals.confirmPassword);
                user.confirmPassword = Console.ReadLine();
                if (user.confirmPassword == "return")
                {
                    return;
                }
                if (user.password == user.confirmPassword)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Literals.inValid);
                }
            }

            bLAuth.RegisterUser(user);
            Console.WriteLine(Literals.regSuccess);
        }

        /// <summary>
        /// this method is for interacting with user for login
        /// </summary>
        public void UserLogIn()
        {
            BLAuthentication bLAuth = new BLAuthentication();

            Validations validate = new Validations();

            string emailId, password;
            bool flag = false;
            string choice;

            Console.Write(Literals.loginEmailId);
            emailId = Console.ReadLine();
            Console.Write(Literals.loginPassword);


            for (int i = 2; i >= 0; i--)
            {
                password = Console.ReadLine();
                if (bLAuth.Login(emailId, password))
                {
                    flag = true;

                    Console.Write(Literals.logOutOrExit);
                    choice = Console.ReadLine();
                    if (choice == "e")
                    {
                        Console.WriteLine(Literals.exit);
                        Environment.Exit(0);
                    }
                    else { return; }
                }
                else
                {

                    Console.Write(Literals.tries, i);
                }
            }
            if (flag)
            {
                Console.WriteLine(Literals.limitReached);
            }

        }

        /// <summary>
        /// this method is for interacting with user for changing the forgotten password
        /// </summary>
        public void ForgotPassword()
        {
            BLAuthentication bLAuth = new BLAuthentication();

            Validations validate = new Validations();

            Users newDetails = new Users();

            Console.Write(Literals.forgotPasswordUserName);
            newDetails.userName = Console.ReadLine();
            Console.Write(Literals.forgotPasswordEmailId);
            newDetails.emailId = Console.ReadLine();
            Console.Write(Literals.forgotPasswordPhoneNo);
            newDetails.phoneNo = Console.ReadLine();
            Console.Write(Literals.newPwd);
            newDetails.password = Console.ReadLine();
            Console.Write(Literals.confirmPwd);
            newDetails.confirmPassword = Console.ReadLine();

            if (newDetails.password == newDetails.confirmPassword)
            {
                if (bLAuth.ForgotPassword(newDetails))
                {
                    Console.WriteLine(Literals.updated);
                    return;
                }
            }
            Console.WriteLine(Literals.notUpdated);
        }


    }
}
