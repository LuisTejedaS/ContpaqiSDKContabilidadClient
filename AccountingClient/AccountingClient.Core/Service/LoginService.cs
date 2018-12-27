using AccountingClient.Schema;
using System;
using AccountingClient.Core.Schema;


namespace AccountingClient.Core 
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AccountingClient.Core.ILoginService" />
    public class LoginService : ILoginService
    {
        /// <summary>
        /// The aut provider
        /// </summary>
        private readonly ILoginService autProvider;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginService"/> class.
        /// </summary>
        /// <param name="autProvider">The aut provider.</param>
        public LoginService(ILoginService autProvider)
        {
            this.autProvider = autProvider;
        }

        /// <summary>
        /// Does the login.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public Session DoLogin(String username, String password)
        {
            return autProvider.DoLogin(username, password);

        }
    }
}
