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
                var thisAmount = rental.getRentalAmount();

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

    }
}