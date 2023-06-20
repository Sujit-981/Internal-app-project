using System.Text.RegularExpressions;


namespace BusinessLayer
{
    /// <summary>
    /// This class contains all the validation methods for input data
    /// </summary>
    public class Validations
    {

        /// <summary>
        /// validation method for username
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsUserNameValid(string userName)
        {

            //if (userName.Length >= 6 && char.IsUpper(userName[0])) { return true; } else { return false; }
            if (Regex.IsMatch(userName, @"^[a-zA-Z0-9_]{6,15}$")) 
            { 
                return true;
            }
            return false;
        }

        /// <summary>
        /// validation method for emailid
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        public bool IsEmailIdValid(string emailId)
        {
            if ((Regex.IsMatch(emailId, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))) 
            {
                return true; 
            } 
            return false;
        }

        /// <summary>
        /// validation method for phone number
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        public bool IsPhoneNoValid(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, @"^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[6789]\d{9}$")) 
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// validation method for password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsPasswordValid(string password)
        {
            if (Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$")) 
            {
                return true;
            }
            return false;
        }
    }
}