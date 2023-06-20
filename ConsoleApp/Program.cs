
using BusinessModels;


namespace ConsoleApp
{
    /// <summary>
    /// This class consists of a enum switch case to take user choice
    /// </summary>
    public class Program
    {
        /// <summary>
        /// this method consists of the enum switch and will communication with the authentication class
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int choice;
            
            Authentication auth = new Authentication();
                       
            while (true)
            {
                Console.WriteLine(Literals.mainSwitch);

                choice = Convert.ToInt32(Console.ReadLine());

                //switch case to jump into required method or to exit the application
                switch ((Menu)choice)
                {
                    case Menu.register:
                        auth.UserRegistration();
                        Console.WriteLine(Literals.line);
                        break;
                    case Menu.login:
                        auth.UserLogIn();
                        Console.WriteLine(Literals.line);
                        break;
                    case Menu.forgotPassword:
                        auth.ForgotPassword();                                    
                        Console.WriteLine(Literals.line);
                        break;
                    case Menu.exit:
                        Console.WriteLine(Literals.exit);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(Literals.inValidChoice);
                        break;
                }
            }
        }
    }
}