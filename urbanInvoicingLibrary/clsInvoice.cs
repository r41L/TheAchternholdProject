using System;

namespace UrbanInvoicingLibraryBUMS
{
    public class clsInvoice
    {
        #region Attribute
        int id, custumerId;
        DateTime date;
        bool printed;
        double sumBrutto, sumNetto, sumMwst;
        #endregion

        #region Konstruktoktor
        public clsInvoice()
        { }
        #endregion
    }
}