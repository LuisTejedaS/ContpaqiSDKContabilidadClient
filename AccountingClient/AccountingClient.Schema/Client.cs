using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingClient.Schema
{
    public class Client
    {
        public string Name { get; set; }
        public string RFC { get; set; }
        public string ProvissionAccount { get; set; }
        public string ComplementaryProvissionAccount { get; set; }
    }
}
