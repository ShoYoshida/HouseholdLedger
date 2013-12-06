using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseholdLedger.View
{
    public class ExpenseView
    {
        public int id { get; set; }
        public string item { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public string payee { get; set; }
        public string who { get; set; }
        public int delflg { get; set; }
        public string date { get; set; }
    }
}