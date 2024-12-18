using System.Data;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.DB.QueryServices
{
    public class PaymentService
    {
        private readonly DatabaseService _databaseService;

        public PaymentService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<Payment> GetAllPayments()
        {
            string query = @"
                    SELECT
                        p.Reservation_Id, p.Amount, p.Payment_Date, p.Payment_Method
                    FROM
                        tbl_Payments p";

            DataTable paymentsTable = _databaseService.ExecuteQuery(query);
            List<Payment> payments = new List<Payment>();

            foreach (DataRow row in paymentsTable.Rows)
            {
                payments.Add(new Payment
                {
                    CarReservationId = Convert.ToInt32(row["Reservation_Id"]),
                    Amount = Convert.ToDecimal(row["Amount"]),
                    PaymentDate = row.IsNull("Payment_Date") ? (DateTime?)null : Convert.ToDateTime(row["Payment_Date"]),
                    PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), row["Payment_Method"].ToString())
                });
            }

            return payments;
        }
    }
}
