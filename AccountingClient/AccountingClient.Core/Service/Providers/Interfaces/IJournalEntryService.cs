using AccountingClient.Core.Schema;
using AccountingClient.Schema;
using System.Collections.Generic;

namespace AccountingClient.Core
{

    /// <summary>
    /// 
    /// </summary>
    public interface IJournalEntryService
    {
        /// <summary>
        /// Gets the journal entry.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        //List<JournalEntry> GetJournalEntry(Session session, JournalEntryFilterWindowModel filter);

        ///// <summary>
        ///// Gets the journal entry movement.
        ///// </summary>
        ///// <param name="session">The session.</param>
        ///// <param name="filter">The filter.</param>
        ///// <returns></returns>
        //List<JournalEntryMovement> GetJournalEntryMovement(Session session, JournalEntryMovementFilterWindowModel filter);


        void CreateJournalEntry(Session session, List<JournalEntry> journalEntries);


    }


}