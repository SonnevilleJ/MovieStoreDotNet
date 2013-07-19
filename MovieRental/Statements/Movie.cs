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
    }
}