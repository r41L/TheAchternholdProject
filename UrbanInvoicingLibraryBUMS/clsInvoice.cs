﻿using System;
using intDatabaseObject;

namespace UrbanInvoicingLibraryBUMS
{
    public class clsInvoice : intDatabaseObject
    {
        #region Attribute
        int id, custumerId;
        DateTime date;
        bool printed;
        double sumGross, sumNet, sumVat;

        #endregion
        #region Konstruktoktor
        public clsInvoice()
        { }

        #endregion
    }
}