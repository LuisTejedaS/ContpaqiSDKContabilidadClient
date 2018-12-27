using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingClient.Core.Schema;
using AccountingClient.Schema;

namespace AccountingClient.Core 
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AccountingClient.Core.IJournalEntryService" />
    public class JournalEntryService : IJournalEntryService
    {
        /// <summary>
        /// The journal entry service
        /// </summary>
        private readonly IJournalEntryService journalEntryService;
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryService"/> class.
        /// </summary>
        /// <param name="journalEntryService">The journal entry service.</param>
        public JournalEntryService(IJournalEntryService journalEntryService)
        {
            this.journalEntryService = journalEntryService;
        }

        /// <summary>
        /// Gets the journal entry.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="journalEntries"></param>
        public void CreateJournalEntry(Session session, List<JournalEntry> journalEntries)
        {
            journalEntryService.CreateJournalEntry(session, journalEntries);
        }

        /// <summary>
        /// Gets the journal entry.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        //public List<JournalEntry> GetJournalEntry(Session session, JournalEntryFilterWindowModel filter)
        //{
        //    return journalEntryService.GetJournalEntry(session, filter);
        //}

        /// <summary>
        /// Gets the journal entry movement.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        //public List<JournalEntryMovement> GetJournalEntryMovement(Session session, JournalEntryMovementFilterWindowModel filter)
        //{
        //    return journalEntryService.GetJournalEntryMovement(session, filter);

        //}

    }
}
