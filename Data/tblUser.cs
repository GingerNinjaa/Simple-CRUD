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
        public  string UserName { get; set; }
        public  string Password { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Position { get; set; }
        public  string Email { get; set; }
    }
}
