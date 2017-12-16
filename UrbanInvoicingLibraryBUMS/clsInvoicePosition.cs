using System;

namespace UrbanInvoicingLibraryBUMS
{
    public class clsInvoicePosition
    {
        #region Attribute
        int id, invoiceId, typeId, artikelId;
        string bemerkung;
        double brutto, netto, mwst, rabat;

        public clsInvoice invoice {get; set;}
        clsType
        clsArtikel artikel;
        #endregion

        #region Kontruktor
        public clsInvoicePosition()
	    {	}
        #endregion
    }
}