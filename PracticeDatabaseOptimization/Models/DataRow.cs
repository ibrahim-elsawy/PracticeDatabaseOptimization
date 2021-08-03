using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDatabaseOptimization.Models
{
    public class DataRow 
    {
        [Key]
        public int RowId { get; set; }
        public DateTime DateTime { get; set; }

        public string VarCol1 { get; set; }

        public string VarCol2 { get; set; }
        public string VarCol3 { get; set; }
    }
}
