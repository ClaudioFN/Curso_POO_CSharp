﻿using System.Globalization;

namespace Entities {
    class Invoice {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment{
            get { return BasicPayment + Tax; }
        }

        public override string ToString() {
            return "Pagamento Basico: " + BasicPayment.ToString("F2", CultureInfo.InstalledUICulture)
                   + "\nTaxa: " + Tax.ToString("F2", CultureInfo.InstalledUICulture)
                   + "\nPagamento Total: " + TotalPayment.ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}