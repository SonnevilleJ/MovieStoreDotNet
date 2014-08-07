namespace MovieRental.Statements
{
    public class StatementCreator
    {
        public string CreateStatement(Customer customer)
        {
            double totalAmount = 0.0;
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + customer.Name + "\n";

            foreach (var rental in customer.GetRentals())
            {
                var thisAmount = getRentalAmount(rental);

                frequentRenterPoints++;

                if (rental.Movie.PriceCode == Movie.NEW_RELEASE && rental.DaysRented > 1)
                    frequentRenterPoints++;

                result += "\t" + rental.Movie.Title + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            result += "You owed " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points\n";

            return result;
        }

        private static double getRentalAmount(Rental rental)
        {
            double thisAmount = 0;

            var daysRented = rental.DaysRented;
            switch (rental.Movie.PriceCode)
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    thisAmount += getExcessMovieAmount(daysRented, 2.0);
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += daysRented*3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    thisAmount += getExcessMovieAmount(daysRented, 3.0);
                    break;
            }
            return thisAmount;
        }

        private static double getExcessMovieAmount(double daysRented, double dayAllotment)
        {
            var price = 0.0;
            if (daysRented > dayAllotment)
                price += (daysRented - dayAllotment)*1.5;
            return price;
        }
    }
}