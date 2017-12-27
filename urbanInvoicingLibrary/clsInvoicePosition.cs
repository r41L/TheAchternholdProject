using System;

namespace UrbanInvoicingLibraryBUMS
{
    public class clsInvoicePosition :clsDatabaseObject
    {
        #region Attribute
        int id, invoiceId, typeId, artikelId;
        string bemerkung;
        double brutto, netto, mwst, rabat;

        public clsType type { get; set; }   
        public clsArticel articel { get; set; }
        public clsInvoice invoice {get; set;}
        #endregion

        #region Kontruktor
        public clsInvoicePosition()
	    {	}

        public clsInvoicePosition(int pId, int pInvoiceId, int pTypeId, int pArtikelId, string pBemerkung,double pBrutto, double pNetto, double pMwst, double pRabat)
        {
            this.id=pId;
            this.invoiceId = pInvoiceId;
            this.typeId = pTypeId;
            this.artikelId = pArtikelId;
            this.bemerkung = pBemerkung;
            this.brutto = pBrutto;
            this.netto = pNetto; 
            this.mwst = pMwst; 
            this.rabat = pRabat;
        }

        protected override void save()
        {
            throw new NotImplementedException();
        }

        protected override void load()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}