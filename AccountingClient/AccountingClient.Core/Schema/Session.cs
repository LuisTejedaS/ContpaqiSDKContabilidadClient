using SDKCONTPAQNGLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingClient.Core.Schema
{
    /// <summary></summary>
    public class Session
    {
        public string Username { get; set; }
        public bool IsValid { get; set; }

        public TSdkSesion LegacySession { get; set; }



    }
}
