namespace ActiveSpace.Models
{
    // 4. الزبائن
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public decimal TotalDebt { get; set; }
        public int NoShowCount { get; set; }
        public string ReliabilityFlag { get; set; } // آمن، خطر، محظور

        public static List<Customer> GetFakeData() => new List<Customer>
        {
            new Customer { CustomerID = 1, FullName = "أحمد محمد", Phone = "0912345678", TotalDebt = 60, ReliabilityFlag = "آمن" },
            new Customer { CustomerID = 2, FullName = "سالم الفيتوري", Phone = "0921112233", TotalDebt = 50, ReliabilityFlag = "مخطر" }
        };
    }
}