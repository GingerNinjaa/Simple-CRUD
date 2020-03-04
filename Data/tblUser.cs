using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    [Table("tblUser")]
    public class tblUser
    {
        [Key]
        public  int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public  string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public  string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public  string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public  string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public  string Position { get; set; }
        [Required]
        [MaxLength(150)]
        public  string Email { get; set; }
    }
}
