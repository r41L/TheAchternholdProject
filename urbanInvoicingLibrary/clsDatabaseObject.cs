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

        protected abstract void save();
        protected abstract void load();
        protected void delete() { throw new NotImplementedException(); }
    }
}