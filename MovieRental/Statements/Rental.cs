namespace MovieRental.Statements
{
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public Movie Movie { get; set; }

        public double DaysRented { get; set; }

        public double getRentalAmount()
        {
            double thisAmount = 0;

            var daysRented = this.DaysRented;
            switch (this.Movie.PriceCode)
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    thisAmount += getExcessMovieAmount(daysRented, 2.0);
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += daysRented * 3;
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
                price += (daysRented - dayAllotment) * 1.5;
            return price;
        }
    }

}