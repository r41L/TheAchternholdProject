using System;
using UrbanInvoicingLibraryBUMS;

namespace UrbanInvoicingLibraryBUMS
{
    public abstract class clsDatabaseObject
    {
        int systemstatusId;
        DateTime addedAt;
        DateTime editedAt;

        clsSystemstatus systemstatus;

        abstract void save();
        abstract void load();
        abstract void delete();
    }
}