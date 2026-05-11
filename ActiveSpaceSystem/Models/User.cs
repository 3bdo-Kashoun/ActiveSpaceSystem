using ActiveSpaceSystem.Models.enums;

namespace ActiveSpace.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public static List<User> GetFakeData() => new List<User>
    {
        new User { UserID = 1, FullName = "عبدالمهيمن الصديق", Username = "admin", Password = "123", Role = UserRole.Admin, IsActive = true },
        new User { UserID = 2, FullName = "محمد يوسف", Username = "staff", Password = "456", Role = UserRole.Staff, IsActive = true },
        
    };


    }
}