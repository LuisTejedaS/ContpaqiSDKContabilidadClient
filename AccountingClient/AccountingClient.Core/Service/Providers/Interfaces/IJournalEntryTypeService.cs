using AccountingClient.Core.Schema;
using AccountingClient.Schema;
using System.Collections.Generic;

namespace AccountingClient.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IJournalEntryTypeService
    {
        /// <summary>
        /// Gets the journal entry types.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        List<JournalEntryType> GetJournalEntryTypes(Session session);

    }
}