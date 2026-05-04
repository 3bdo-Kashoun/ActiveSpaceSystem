using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveSpace.Models;

namespace ActiveSpaceSystem.Data
{
    internal class DataStorage
    {
        public static List<User> UsersList = new List<User>();
       public static List<Booking> BookingsList = new List<Booking>();
        public static List<Court> CourtsLisList = new List<Court>();
        public static List<CourtType> CourtTypesList = new List<CourtType>();
        public static List<Customer> CustomersList = new List<Customer>();
        public static List<MonthlyContract> MonthlyContractsList = new List<MonthlyContract>();
        public static List<Payment> PaymentsList = new List<Payment>();


        static DataStorage()
        {
            UsersList = GetFakeData();
        }
        private static List<User> GetFakeData() => new List<User>
    {
        new User { UserID = 1, FullName = "عبدالمهيمن الصديق", Username = "admin", Password = "123", Role = UserRole.Admin, IsActive = true },
        new User { UserID = 2, FullName = "محمد يوسف", Username = "staff", Password = "456", Role = UserRole.Staff, IsActive = true }
    };

    }


}
