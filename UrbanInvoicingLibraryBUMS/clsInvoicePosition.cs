using System;

namespace UrbanInvoicingLibraryBUMS
{
    public class clsInvoicePosition
    {
        #region Attribute
        int id, invoiceId, typeId, artikelId;
        string bemerkung;
        double brutto, netto, mwst, rabat;

        clsInvoice invoice;
        clsType type;
        clsArtikel artikel;
        #endregion

        #region Kontruktor
        public clsInvoicePosition()
	    {	}
        #endregion
    }
}