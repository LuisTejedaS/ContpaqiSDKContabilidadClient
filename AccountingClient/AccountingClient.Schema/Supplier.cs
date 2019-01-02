using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingClient.Schema
{
    public class Supplier
    {
        public string Name { get; set; }
        public string RFC { get; set; }
        public string Account { get; set; }
        public string ComplementaryAccount { get; set; }
        public string ExpenseAccount { get; set; }
        public string ComplementaryExpenseAccount { get; set; }
    }
}
