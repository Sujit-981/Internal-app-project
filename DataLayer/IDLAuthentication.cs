
using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// has method definations for dlauthentication class
    /// </summary>
    public interface IDLAuthentication
    {
        public void InsertUser(Users user);
        public void UpdateCredentials(Users newDetails);
        public bool IsRegisterDataExists(string emailId, string phoneNo);
        public bool IsLoginDataExists(string emailId, string password);
        public bool IsUpdateCredentialsExists(string emailId, string userName, string phoneNo);

    }
}
