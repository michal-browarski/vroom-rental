namespace VroomRental.Backend.Model
{
    public class CarReservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public ReservationStatus Status { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public Employee Employee { get; set; }
        public Payment? Payment { get; set; }
        public List<AdditionalOption> AdditionalOptions { get; set; } = new List<AdditionalOption>();

        // Właściwości pomocnicze
        public string CustomerFullName { get; set; }
        public string CarDetails { get; set; }
        public string AdditionalOptionsSummary
        {
            get
            {
                return AdditionalOptions != null && AdditionalOptions.Count > 0
                    ? string.Join(", ", AdditionalOptions.Select(o => o.Name))
                    : "No options";
            }
        }
    }
}
