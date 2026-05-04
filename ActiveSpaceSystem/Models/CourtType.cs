namespace ActiveSpace.Models
{
    
    public class CourtType
    {
        public int TypeID { get; set; }
        public  string TypeName { get; set; }
      

        public static List<CourtType> GetFakeData() => new List<CourtType>
        {
            new CourtType { TypeID = 1, TypeName = "كرة قدم"},
            new CourtType { TypeID = 2, TypeName = "بادل" },
            new CourtType { TypeID = 3, TypeName = "كرة سلة" }
        };
    }
}