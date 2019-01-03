using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingClient.Schema
{
    public class JournalEntryMovement
    {
        public int Number { get; set; }
        public string Account { get; set; }
        public JournalEntryMovementType JournalEntryMovementType { get; set; }
        public int JournalEntryMovementDaily { get; set; }
        public string Concept { get; set; }
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFC { get; set; }
        public Guid Guid { get; set; }
        public string UUIDReferences { get; set; }
        public List<Guid> UUIDReferenciesGuid { get; set; }


    }
    public enum JournalEntryMovementType
    {
        DEBITS = 1,
        CREDITS = 2
    }
}