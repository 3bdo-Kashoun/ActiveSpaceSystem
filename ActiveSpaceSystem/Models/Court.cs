namespace ActiveSpace.Models
{
    // 3. الملاعب
    public class Court
    {
        public int CourtID { get; set; }
        public int TypeID { get; set; }
        public string CourtName { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public string Status { get; set; }

        // Navigation Property
        public CourtType Type { get; set; }

        public static List<Court> GetFakeData() => new List<Court>
        {
            new Court { CourtID = 1, CourtName = "ملعب المدينة 1", TypeID = 1, Status = "متاح", OpenTime = new TimeSpan(8,0,0), CloseTime = new TimeSpan(23,0,0) },
            new Court { CourtID = 2, CourtName = "ملعب البادل الرئيسي", TypeID = 2, Status = "متاح", OpenTime = new TimeSpan(10,0,0), CloseTime = new TimeSpan(0,0,0) }
        };
    }
}