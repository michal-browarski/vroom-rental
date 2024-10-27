namespace VroomRental.Backend.Model
{
    public enum PaymentMethod
    {
        Card = 1,
        Cash,
        BankTransfer
    }

    public enum Role
    {
        Admin = 1,
        CustomerService,
        Repairs
    }

    public enum RepairStatus
    {
        Reported = 1,
        InRepair,
        Done
    }

    public enum ReservationStatus
    {
        Active = 1,
        Ended,
        Canceled
    }

    public enum CarStatus
    {
        Available = 1,
        Rented,
        InRepair
    }
}
