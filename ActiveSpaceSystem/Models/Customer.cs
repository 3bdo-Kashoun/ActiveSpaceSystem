namespace ActiveSpace.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public decimal TotalDebt { get; set; }
       
       
        public static List<Customer> GetFakeData() => new List<Customer>
        {
            new Customer { CustomerID = 1, FullName = "أحمد محمد", Phone = "0912345678", TotalDebt = 60, },
            new Customer { CustomerID = 2, FullName = "سالم الفيتوري", Phone = "0921112233", TotalDebt = 50 }
        };
    }
    
}