using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.Models
{
    public class Lease
    {
        [Key]
        public int ID { get; set; }
        public int SlipId { get; set; }
        public string CustomerID { get; set; }

        [ForeignKey("SlipId")]
        public virtual Slip Slip { get; set; }


        public virtual Customer Customer { get; set; }
    }
}
