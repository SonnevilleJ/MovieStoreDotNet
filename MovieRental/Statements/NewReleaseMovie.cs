namespace MovieRental.Statements
{
    public class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string title)
            : base(title, NEW_RELEASE)
        {
        }

        public override double GetMovieAmount(double daysRented)
        {
            return daysRented*3;
        }
    }
}