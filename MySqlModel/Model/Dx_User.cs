using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlModel.Model
{

    [Table("Dx_User")]
    public class Dx_User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string UserPassword { get; set; }
        [StringLength(10)]
        public string Birthday { get; set; }
        public int RoleId { get; set; }

        //将string映射成ntext，默认为nvarchar(max)
        [Column(TypeName = "ntext")]
        public string Memo { get; set; }
    }
}
