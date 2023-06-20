
namespace DataLayer
{
    /// <summary>
    /// contains a method which will return the object of the dlauthenticatioon class
    /// </summary>
    public class DataFactory
    {
        /// <summary>
        /// this method will return the object of the dkauthentication class
        /// </summary>
        /// <returns></returns>
        public IDLAuthentication GetDLAuthObj()
        {
            return new DLAuthentication();
        }
    }
}
