namespace VroomRental.Backend.Model
{
    public class Payment
    {
        public int CarReservationId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
