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
            return Movie.GetMovieAmount(DaysRented);
        }
    }

}