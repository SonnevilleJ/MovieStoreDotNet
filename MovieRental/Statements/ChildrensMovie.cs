namespace MovieRental.Statements
{
    public class ChildrensMovie : Movie
    {
        public ChildrensMovie(string title)
            : base(title)
        {
        }

        public override double GetMovieAmount(double daysRented)
        {
            return 1.5 + GetExcessMovieAmount(daysRented, 3.0);
        }
    }
}