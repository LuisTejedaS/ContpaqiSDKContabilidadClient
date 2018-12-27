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
    /// <seealso cref="AccountingClient.Core.IJournalEntryTypeService" />
    public class JournalEntryTypeService : IJournalEntryTypeService
    {
        /// <summary>
        /// The journal entry type service
        /// </summary>
        private readonly IJournalEntryTypeService journalEntryTypeService;
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryTypeService"/> class.
        /// </summary>
        /// <param name="journalEntryTypeService">The journal entry type service.</param>
        public JournalEntryTypeService(IJournalEntryTypeService journalEntryTypeService)
        {
            this.journalEntryTypeService = journalEntryTypeService;
        }

        /// <summary>
        /// Gets the journal entry types.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public List<JournalEntryType> GetJournalEntryTypes(Session session)
        {
            return journalEntryTypeService.GetJournalEntryTypes(session);
        }
    }
}
