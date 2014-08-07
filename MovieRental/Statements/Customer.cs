using System.Collections.Generic;

namespace MovieRental.Statements
{
    public class Customer
    {
        public Customer(string name)
        {
            Rentals = new List<Rental>();
            this.Name = name;
        }

        public string Name { get; private set; }

        private List<Rental> Rentals { get; set; }

        public void AddRental(Rental rental)
        {
            Rentals.Add(rental);
        }

        public IEnumerable<Rental> GetRentals()
        {
            return Rentals.AsReadOnly();
        }
    }
}