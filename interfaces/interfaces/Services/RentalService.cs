using System;
using System.Collections.Generic;
using Entities;

namespace Services {
    class RentalService {
        public double PricePerHoury { get; private set; }
        public double PricePerDay { get; private set; }
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        public RentalService(double pricePerHoury, double pricePerDay) {
            PricePerHoury = pricePerHoury;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0) {
                basicPayment = PricePerHoury * Math.Ceiling(duration.TotalHours);
            }
            else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
