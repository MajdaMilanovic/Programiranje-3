using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB200165
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB200165
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetiIB200165 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
