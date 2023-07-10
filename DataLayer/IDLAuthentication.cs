
namespace DataLayer
{
    /// <summary>
    /// has method definations for dlauthentication class
    /// </summary>
    public interface IDLAuthentication
    {
        //public dynamic Converter<T1, T2>(dynamic model) where T1 : BusinessModels.User, new() where T2 : DataModels.User, new();
        //public dynamic Converter<T1, T2>(dynamic model) where T1 : new() where T2 : new();
        public void InsertUser(BusinessModels.User user);
        public void UpdateCredentials(BusinessModels.User newDetails);
        public bool IsRegisterDataExists(string emailId, string phoneNo);
        public bool IsLoginDataExists(string emailId, string password);
        public bool IsUpdateCredentialsExists(string emailId, string userName, string phoneNo);
        public BusinessModels.User GetUserData(string userName, string password);
    }
}
