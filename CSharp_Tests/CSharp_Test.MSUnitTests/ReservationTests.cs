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
                    Name = "John Doe"
                }
            };

            //Act
            var results = reservation.CanBeCancelledBy(new User
            {
                IsAdmin = true,
            });

            //Assert

            Assert.IsTrue(results);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdmin_ReturnsFalse()
        {
            //Arrange

            var reservation = new Reservation
            {
                ReservationMadeBy = new User
                {
                    IsAdmin = false,
                }
            };

            //Act
            var results = reservation.CanBeCancelledBy(new User
            {
                IsAdmin = false,
            });

            //Assert

            Assert.IsTrue(results);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminButSameUser_ReturnsFalse()
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
    } //end of class
}