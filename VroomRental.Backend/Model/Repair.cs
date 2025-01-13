namespace VroomRental.Backend.Model
{
    public class Repair
    {
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }
        public string Description { get; set; }
        public RepairStatus Status { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Cost { get; set; }
        public Employee Employee { get; set; }
        public Car Car { get; set; }
        public string CarDetails { get; set; }
    }
}
