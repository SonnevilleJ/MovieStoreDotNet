namespace MovieRental.Statements
{
    public class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string title)
            : base(title)
        {
        }

        public override double GetMovieAmount(double daysRented)
        {
            return daysRented*3;
        }

        public override int CalculateExtraFrequentRenterPoints(double daysRented)
        {
            if (daysRented > 1)
                return 1;
            return 0;
        }
    }
}