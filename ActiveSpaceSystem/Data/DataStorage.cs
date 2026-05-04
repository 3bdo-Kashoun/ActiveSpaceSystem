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
