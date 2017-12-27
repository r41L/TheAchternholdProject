using System;
using UrbanInvoicingLibraryBUMS;

namespace UrbanInvoicingLibraryBUMS
{
    public abstract class clsDatabaseObject
    {
        int systemstatusId;
        DateTime addedAt;
        DateTime editedAt;

        public clsSystemstatus systemstatus { get; set; }

        abstract void save();
        abstract void load();
        protected void delete();
    }
}