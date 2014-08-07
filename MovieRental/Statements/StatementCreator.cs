﻿namespace MovieRental.Statements
{
    public class StatementCreator
    {
        public string CreateStatement(Customer customer)
        {
            double totalAmount = 0.0;
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + customer.Name + "\n";

            foreach (var rental in customer.GetRentals())
            {
                double thisAmount = 0;

                switch (rental.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (rental.DaysRented > 2)
                            thisAmount += (rental.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += rental.DaysRented * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (rental.DaysRented > 3)
                            thisAmount += (rental.DaysRented - 3) * 1.5;
                        break;
                }

                frequentRenterPoints++;

                if (rental.Movie.PriceCode == Movie.NEW_RELEASE && rental.DaysRented > 1)
                    frequentRenterPoints++;

                result += "\t" + rental.Movie.Title + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            result += "You owed " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points\n";

            return result;
        }
    }
}