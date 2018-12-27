using AccountingClient.Schema;
using SDKCONTPAQNGLib;
using System;
using AccountingClient.Core.Schema;


namespace AccountingClient.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AccountingClient.Core.ILoginService" />
    public class ContpaqLegacySessionProvider : ILoginService
    {
        /// <summary>
        /// Does the login.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public Session DoLogin(string username, string password)
        {
            Session session = new Session();

            TSdkSesion sdkSession = new TSdkSesion();
            sdkSession.firmaUsuarioParams(username, password);
            session.IsValid = Convert.ToBoolean(sdkSession.conexionActiva);
            session.Username = username;
            session.LegacySession = sdkSession;
            return session;
        }

    }
}
