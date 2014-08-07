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

                var movie = rental.Movie;
                frequentRenterPoints += movie.CalculateExtraFrequentRenterPoints(rental.DaysRented);

                result += "\t" + movie.Title + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            result += "You owed " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points\n";

            return result;
        }
    }
}