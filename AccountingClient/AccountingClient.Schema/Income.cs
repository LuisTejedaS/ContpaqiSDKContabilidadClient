using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingClient.Schema
{
    public class Income
    {
        public string BankAccount { get; set; }
        public string Date { get; set; }
        public string DocumentType { get; set; }
        public string Number { get; set; }
        public string PayerCode { get; set; }
        public string PayerName { get; set; }
        public string Total { get; set; }
        public string Reference { get; set; }
        public string Concept { get; set; }
        public string PaymentMethod { get; set; }
        public string BankSource { get; set; }
        public string BankAccountSource { get; set; }
        public string Currency { get; set; }
        public string ExchangeRate { get; set; }
        public string Guid { get; set; }
        public List<Guid> UUIDReferenciesGuid { get; set; }

    }
}
