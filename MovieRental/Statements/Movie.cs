namespace MovieRental.Statements
{
    public class Movie
    {
        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public const int REGULAR = 1;
        public const int NEW_RELEASE = 2;
        public const int CHILDRENS = 3;

        public int PriceCode { get; set; }

        public string Title { get; set; }

        public double GetMovieAmount(double daysRented)
        {
            double thisAmount = 0;
            switch (PriceCode)
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