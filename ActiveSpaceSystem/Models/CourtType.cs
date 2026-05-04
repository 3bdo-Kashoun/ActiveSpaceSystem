namespace ActiveSpace.Models
{
    
    public class CourtType
    {
        public int TypeID { get; set; }
        public required string TypeName { get; set; }
        public decimal PricePerHour { get; set; }

        public static List<CourtType> GetFakeData() => new List<CourtType>
        {
            new CourtType { TypeID = 1, TypeName = "كرة قدم خماسي", PricePerHour = 50 },
            new CourtType { TypeID = 2, TypeName = "بادل تنس", PricePerHour = 80 },
            new CourtType { TypeID = 3, TypeName = "كرة سلة", PricePerHour = 40 }
        };
    }
}