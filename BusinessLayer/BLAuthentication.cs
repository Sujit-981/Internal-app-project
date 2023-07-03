
using BusinessModels;
using DataLayer;

namespace BusinessLayer
{
    /// <summary>
    /// in this class we create the object for datafactory class and through it we access the methods of the data authentication layer
    /// </summary>
    public class BLAuthentication
    {
        /*public DataFactory dataFactoryObj;
        public BLAuthentication()
        {
            DataFactory dataFactoryObj = new DataFactory();
        }*/

        DataFactory dataFactoryObj = new DataFactory();

        /// <summary>
        /// this method will send data to datalayer for registration
        /// </summary>
        /// <param name="user"></param>
        public void RegisterUser(User user)
        {
            BLAuthentication bLAuth = new BLAuthentication();
            IDLAuthentication iDLAuth = dataFactoryObj.GetDLAuthObj();

            iDLAuth.InsertUser(user);
        }

        /// <summary>
        /// this method communicates with the datalayer for required operations of the forgot password
        /// </summary>
        /// <param name="newDetails"></param>
        /// <returns></returns>
        public bool ForgotPassword(User newDetails)
        {
            IDLAuthentication iDLAuth = dataFactoryObj.GetDLAuthObj();

            if (iDLAuth.IsUpdateCredentialsExists(newDetails.emailId, newDetails.userName, newDetails.phoneNo))
            {
                iDLAuth.UpdateCredentials(newDetails);
                return true;
            }

            return false;
        }

        /// <summary>
        /// this method sends data to datalayer for validation
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        public bool Register(string emailId, string phoneNo)
        {
            IDLAuthentication iDLAuth = dataFactoryObj.GetDLAuthObj();

            if (iDLAuth.IsRegisterDataExists(emailId, phoneNo))
            {
                return true; 
            }
            return false; 
        }

        /// <summary>
        /// this layer sends data to datalayer for validation
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string emailId, string password)
        {

            IDLAuthentication iDLAuth = dataFactoryObj.GetDLAuthObj();
            if (iDLAuth.IsLoginDataExists(emailId, password)) 
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
        }
    }
}
