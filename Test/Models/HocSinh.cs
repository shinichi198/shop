using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    [Table("HocSinhs")]
   public class HocSinh
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int LopHocID { get; set; }
        [StringLength(150)]
        public string HoTen { get; set; }

        [ForeignKey("Lops")]
        public virtual IList<Lop> Lops { get; set; }
    }
}
