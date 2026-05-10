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
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; } 
        public DateTime ExpenseDate { get; set; } = DateTime.Now;

        // الربط مع الفئة
        public int ExpenseTypeId { get; set; }
        public ExpenseType ExpenseType { get; set; }

        // خاصية مساعدة للـ DataGrid لعرض اسم الفئة مباشرة
        public string CategoryName => ExpenseType?.ExpenseName ?? "غير محدد";
    }
}
