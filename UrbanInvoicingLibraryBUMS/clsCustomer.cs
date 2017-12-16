using System;

namespace UrbanInvoicingLibraryBUMS
{
    public class clsCustomer
    {
        #region Attribute
        int id;
        string name;
        string lastName;
        string street;
        string plz;
        string city;
        string land;
        string telefone;
        string telefax;
        string email;
        string note;
        bool isCompany; 
        #endregion

        #region Konstruktor
        public clsCustomer()
        {   }
        #endregion
    }
}
