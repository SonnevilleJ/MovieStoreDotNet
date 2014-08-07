namespace MovieRental.Statements
{
    public abstract class Movie
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

        public abstract double GetMovieAmount(double daysRented);

        protected static double GetExcessMovieAmount(double daysRented, double dayAllotment)
        {
            var price = 0.0;
            if (daysRented > dayAllotment)
                price += (daysRented - dayAllotment) * 1.5;
            return price;
        }
    }
}