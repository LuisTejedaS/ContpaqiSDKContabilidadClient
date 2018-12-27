using AccountingClient.Schema;
using AccountingClient.Core.Schema;

namespace AccountingClient.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// Does the login.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Session DoLogin(string username, string password);

    }
}