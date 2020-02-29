using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache
{
  public static  class ActiveUser
    {
        public static int c_Id { get; set; }
        public static string c_UserName { get; set; }
        public static string c_Password { get; set; }
        public static string c_FirstName { get; set; }
        public static string c_LastName { get; set; }
        public static string c_Position { get; set; }
        public static string c_Email { get; set; }

      //Reset Cache
        public static void Reset()
        {
            c_Id = 0;
            c_UserName = null;
            c_Password = null;
            c_FirstName = null;
            c_LastName = null;
            c_Position = null;
            c_Email = null;
        }
       
    }
}
