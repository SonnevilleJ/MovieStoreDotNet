namespace MovieRental.Statements
{
    public class RegularMovie : Movie
    {
        public RegularMovie(string title)
            : base(title, REGULAR)
        {
        }

        public override double GetMovieAmount(double daysRented)
        {
            return 2 + GetExcessMovieAmount(daysRented, 2.0);
        }
    }
}