using CSharp_Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Test.MSUnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        //public void Method_Scenario_ExpectedBehavior()
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange

            var reservation = new Reservation
            {
                ReservationMadeBy = new User
                {
                    IsAdmin = false, 
                    Name = "Admin"
                }
            };

            //Act
            var results = reservation.CanBeCancelledBy(new User
            {
                IsAdmin = false,
                Name = "Admin"
            });

            //Assert

            Assert.IsTrue(results);


        }
    }
}
