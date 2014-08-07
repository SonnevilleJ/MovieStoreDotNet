namespace MovieRental.Statements
{
    public class ChildrensMovie : Movie
    {
        public ChildrensMovie(string title)
            : base(title, CHILDRENS)
        {
        }

        public override double GetMovieAmount(double daysRented)
        {
            return 1.5 + GetExcessMovieAmount(daysRented, 3.0);
        }
    }
}