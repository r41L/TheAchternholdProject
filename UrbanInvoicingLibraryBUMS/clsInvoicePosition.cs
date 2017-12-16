using System;

public class clsInvoicePosition
{
    #region Attribute
    int id, invoiceId, typeId, artikelId;
    string comment;
    double gross, net, vat, discount;

    clsInvoice invoice;
    clsType type;
    clsArtikel artikel;
    #endregion

    #region Kontruktor
    public clsInvoicePosition()
	{	}
    #endregion
}
