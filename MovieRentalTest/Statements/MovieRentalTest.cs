using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental.Statements;

namespace MovieRentalTest.Statements
{
    [TestClass]
    public class MovieRentalTest
    {
        [TestMethod]
        public void ShouldProduceAStatement()
        {
            var customer = new Customer("Bob");
            customer.AddRental(new Rental(new Movie("Pulp Fiction", Movie.REGULAR), 2));
            customer.AddRental(new Rental(new Movie("Lilo & Stitch", Movie.CHILDRENS), 3));
            customer.AddRental(new Rental(new Movie("Gladiator", Movie.REGULAR), 6));
            customer.AddRental(new Rental(new Movie("Magic Mike", Movie.NEW_RELEASE), 4));

            var statementCreator = new StatementCreator();
            var bobsStatement = statementCreator.CreateStatement(customer);

            const string expectedStatement = "Rental Record for Bob\n" +
                                             "\tPulp Fiction\t2\n" +
                                             "\tLilo & Stitch\t1.5\n" +
                                             "\tGladiator\t8\n" +
                                             "\tMagic Mike\t12\n" +
                                             "You owed 23.5\n" +
                                             "You earned 5 frequent renter points\n";

            Assert.AreEqual(expectedStatement, bobsStatement);
        }
    }
}
