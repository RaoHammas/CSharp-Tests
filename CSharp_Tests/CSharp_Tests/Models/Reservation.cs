namespace CSharp_Tests.Models
{
    public class Reservation
    {
        public User ReservationMadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return user.IsAdmin || user.Name == ReservationMadeBy.Name;
        }




    } //end of class
}
