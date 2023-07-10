using System;


namespace BusinessModels
{
    /// <summary>
    /// this class is for storing all the literals and using where ever required
    /// </summary>
    public static class Literals
    {
        //Switch case prompt literals
        public static string mainSwitch = "Enter your choice and proceed:\n1 for Registration\n2 for Login\n3 for data retrival\n4 for forgot password\n5 for exiting the application";
        public static string line = "\n-----------------------------------------------------------------------------------------------";
        public static string inValidChoice = "The choice you have entered is wrong, Please enter a valid choice";
        public static string exit = "You are exiting the application";

        //Registering literals
        public static string userName = "Enter a username starting with a capital letter and having atleast 6 characters: ";
        public static string emailId = "Enter a valid email id having '@' and '.' in order: ";
        public static string phoneNo = "Enter a valid phone number having 10 digits: ";
        public static string password = "Enter a password having atleast one uppercase, one lower case, one number, one special character and having atleast 8 characters: ";
        public static string confirmPassword = "Enter the same password again: ";
        public static string inValid = "Invalid data entered, Please enter a valid one or type 'return' to return to the home page";
        public static string alreadyExists = "The email or phone number you have entered to register already exists, please try logging in or try to register with other credentials";
        public static string regSuccess = "The user details have been sucessfully updated and user is registered";
        public static string regFailure = "The details entered already exists";

        //Login literals
        public static string loginEmailId = "Enter your registered emailId to log in: ";
        public static string loginPassword = "Enter your password: ";
        public static string tries = "You have {0} tries left, try again: ";
        public static string logOutOrExit = "If you want to logout type any string and hit enter, if you want to exit type 'e' and hit enter: ";
        public static string limitReached = "You are at your password limit.........returning to home page";


        //getdata literals
        public static string dataUserName = "To get your details enter your username: ";
        public static string dataPassword = "Enter your password: ";
        public static string dataDoesNotExist = "The entered user does not exist";
        public static string dataEmailId = "Your registered email id is: ";
        public static string dataPhoneNumber = "Your registered phone number is: ";


        //forgot password literals
        public static string forgotPasswordUserName = "Enter your registered user name for verification: ";
        public static string forgotPasswordEmailId = "Enter your registered email id for verification: ";
        public static string forgotPasswordPhoneNo = "Enter the registered phone number: ";
        public static string newPwd = "Enter a new password: ";
        public static string confirmPwd = "Confirm the new password: ";
        public static string updated = "The new password is successfully updated";
        public static string notUpdated = "The password is not updated";

    }
}
