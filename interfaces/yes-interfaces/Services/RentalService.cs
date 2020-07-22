using System;
using Entities;
using yes_interfaces.Services;

namespace Services {
    class RentalService {
        public double PricePerHoury { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;
        public RentalService(double pricePerHoury, double pricePerDay, ITaxService taxService) {
            PricePerHoury = pricePerHoury;
            PricePerDay = pricePerDay;
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
