using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlServerModel.Model
{
    [Table("Dx_Role")]
    public class Dx_Role
    {
        [Key]
        public int RoleId { get; set; }
        [StringLength(20)]
        public string RoleName { get; set; }
        public int Status { get; set; }
    }
}
