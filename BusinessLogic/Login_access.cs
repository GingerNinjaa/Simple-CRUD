using Cache;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class Login_access
    {
        public string User { get; set; }
        public string Password { get; set; }

        public Login_access(string user,string pass)
        {
            this.User = user;
            this.Password = pass;
        }


        public void Logowanie()
        {
            bool isValid = false;

            using (DbModel db = new DbModel())
            {
                if (db.Users.Any(x => x.UserName.Equals(this.User) && x.Password.Equals(this.Password)))
                {
                    isValid = true;
                }

                if (isValid == false)
                {
                    throw new Exception("Wrong Data");
                }
                else
                {
                    tblUser user = new tblUser();
                    user = db.Users.FirstOrDefault(x => x.UserName == this.User);

                    // Transwer data to Cache 
                    ActiveUser.c_Id = user.UserId;
                    ActiveUser.c_UserName = user.UserName;
                    ActiveUser.c_Password = user.Password;
                    ActiveUser.c_FirstName = user.FirstName;
                    ActiveUser.c_LastName = user.LastName;
                    ActiveUser.c_Position = user.Position;
                    ActiveUser.c_Email = user.Email;

                }
            }
        }
    }
}
