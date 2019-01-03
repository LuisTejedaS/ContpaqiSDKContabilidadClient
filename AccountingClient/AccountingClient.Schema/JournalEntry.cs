using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingClient.Schema
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public int FiscalYear { get; set; }
        public int Period { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public bool Affect { get; set; }
        public bool Printed { get; set; }
        public string Concept { get; set; }
        public decimal Debits { get; set; }
        public decimal Credits { get; set; }
        public int Daily { get; set; }
        public string SourceSystem { get; set; }
        public bool Adjust { get; set; }
        public string User { get; set; }
        public string LastErrorMessage { get; set; }
        public int NumberOfMovements { get; set; }
        public int IVAControlNumberOfMovements { get; set; }
        public Guid Guid { get; set; }
        public string AsocReference { get; set; }
        public string UUIDReferences { get; set; }

        public List<JournalEntryMovement> JournalEntryMovement { get; set; }
        public List<Guid> UUIDReferenciesGuid { get; set; }

    }
}