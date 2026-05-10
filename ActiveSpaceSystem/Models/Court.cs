using ActiveSpaceSystem.Models;
using ActiveSpaceSystem.Models.enums;

namespace ActiveSpace.Models
{
    public class Court
    {
        public int CourtID { get; set; }
        public int TypeID { get; set; }
        public string CourtName { get; set; } = string.Empty;
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public CourtStatus Status { get; set; }

        public string Category { get; set; }
        public CourtType? Type { get; set; }

        public static List<Court> GetFakeData() => new List<Court>
        {
            new Court { CourtID = 1, CourtName = "ملعب المدينة 1", TypeID = 1, OpenTime = new TimeSpan(8,0,0), CloseTime = new TimeSpan(23,0,0) ,Type=CourtType.GetFakeData().FirstOrDefault(c=>c.TypeID==1)},
            new Court { CourtID = 2, CourtName = "ملعب البادل الرئيسي", TypeID = 2, OpenTime = new TimeSpan(10,0,0), CloseTime = new TimeSpan(0,0,0),Type=CourtType.GetFakeData().FirstOrDefault(c=>c.TypeID==2) }
        };
        

    }
}