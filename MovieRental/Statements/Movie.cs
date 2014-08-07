namespace MovieRental.Statements
{
    public abstract class Movie
    {
        public Movie(string title)
        {
            Title = title;
        }

        public string Title { get; set; }

        public abstract double GetMovieAmount(double daysRented);

        protected static double GetExcessMovieAmount(double daysRented, double dayAllotment)
        {
            var price = 0.0;
            if (daysRented > dayAllotment)
                price += (daysRented - dayAllotment) * 1.5;
            return price;
        }

        public virtual int CalculateExtraFrequentRenterPoints(double daysRented)
        {
            return 0;
        }
    }
}