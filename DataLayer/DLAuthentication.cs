using AutoMapper;


namespace DataLayer
{
    /// <summary>
    /// this class is hidden for presentation layer, it inherits the interface and implements the code for the method definations in it
    /// </summary>
    internal class DLAuthentication : IDLAuthentication
    {
        /// <summary>
        /// This will convert the business model user to data model user and vice versa.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public dynamic Converter<T1, T2>(dynamic model) where T1 : new() where T2 : new()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });

            var mapper = new Mapper(config);
            return mapper.Map<T1, T2>(model);
        }
        
        /// <summary>
        /// This method is used to store data in the list 
        /// </summary>
        /// <param name="user"></param>
        public void InsertUser(BusinessModels.User user)
        {
            DLAuthentication DLAuth = new DLAuthentication();
            DataSource.userList.Add(DLAuth.Converter<BusinessModels.User, DataModels.User>(user));
        }

        /// <summary>
        /// this method will update the password
        /// </summary>
        /// <param name="newDetails"></param>
        public void UpdateCredentials(BusinessModels.User newDetails)
        {
            foreach (DataModels.User user in DataSource.userList)
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
            DataModels.User user = DataSource.userList.Find(check => check.emailId == emailId && check.phoneNo == phoneNo);

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
            DataModels.User user = DataSource.userList.Find(check => check.emailId == emailId && check.password == password);

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
            DataModels.User user = DataSource.userList.Find(check => check.emailId == emailId && check.userName == userName && check.phoneNo == phoneNo);

            if (user != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method will return the user details if it exists
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public BusinessModels.User GetUserData(string userName, string password)
        {
            DataModels.User user = DataSource.userList.Find(check => check.userName == userName && check.password == password);
                        
            if (user != null)
            {
                DLAuthentication DLAuth = new DLAuthentication();
                return DLAuth.Converter<DataModels.User, BusinessModels.User>(user);
            }
            return null;
        }
    }
}