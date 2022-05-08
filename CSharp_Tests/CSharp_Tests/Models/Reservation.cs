namespace CSharp_Tests.Models
{
    public class Reservation
    {
        public User ReservationMadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin || user.Name == ReservationMadeBy.Name)
            {
                return true;
            }
            
            return false;
        }




    } //end of class
}
