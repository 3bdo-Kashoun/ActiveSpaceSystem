using ActiveSpace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveSpaceSystem.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }

        
        public string Title { get; set; } = string.Empty;

       
        public string Description { get; set; } = string.Empty;

       
        public double Amount { get; set; }

        
        public DateTime ExpenseDate { get; set; } = DateTime.Now;

        
        public int UserID { get; set; }

      
        public int? CourtID { get; set; }
        public Court? Court { get; set; }
    
    }
}
