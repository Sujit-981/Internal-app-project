﻿using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// this class is hidden for presentation layer, it inherits the interface and implements the code for the method definations in it
    /// </summary>
    internal class DLAuthentication : IDLAuthentication
    {

        /// <summary>
        /// This method is used to store data in the list
        /// </summary>
        /// <param name="user"></param>
        public void InsertUser(Users user)
        {
            DataSource.userList.Add(user);
        }

        /// <summary>
        /// this method will update the password
        /// </summary>
        /// <param name="newDetails"></param>
        public void UpdateCredentials(Users newDetails)
        {
            foreach (Users user in DataSource.userList)
            {
                if (user.userName == newDetails.userName && user.emailId == newDetails.emailId && user.phoneNo == newDetails.phoneNo)
                {
                    user.password = newDetails.password;
                    user.confirmPassword = newDetails.confirmPassword;
                    break;
                }
            }
        }

        /// <summary>
        /// checks if the email and phone number already exists or not
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        public bool IsRegisterDataExists(string emailId, string phoneNo)
        {
            Users user = DataSource.userList.Find(check => check.emailId == emailId && check.phoneNo == phoneNo);

            if (user != null)
            {
                return true;
            }
            return false;

        }
        /// <summary>
        /// checks if the email and password exists or not, for logging in
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsLoginDataExists(string emailId, string password)
        {
            Users user = DataSource.userList.Find(check => check.emailId == emailId && check.password == password);

            if(user != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// for checking if the provided update credentials exists in list or not
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="userName"></param>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        public bool IsUpdateCredentialsExists(string emailId, string userName, string phoneNo)
        {
            Users user = DataSource.userList.Find(check => check.emailId == emailId && check.userName == userName && check.phoneNo == phoneNo);

            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}