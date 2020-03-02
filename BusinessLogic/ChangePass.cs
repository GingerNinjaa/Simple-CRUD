using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class ChangePass
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string PasswordConf { get; set; }

        public ChangePass(string user,string pass, string passconf)
        {
            this.User = user;
            this.Password = pass;
            this.PasswordConf = passconf;
        }

        public void Change()
        {
            tblUser model = new tblUser();

            bool isValid = true;

            if (this.Password != this.PasswordConf)
            {
                isValid = false;
                throw new Exception("Password not match");
            }

            if (isValid == true)
            {
                using (DbModel db = new DbModel())
                {

                    model = db.Users.Where(x => x.UserName == this.User).FirstOrDefault();

                    if (model.Position != "admin")
                    {
                        model.Password = this.Password;

                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("User is admin");
                    }
                }
            }
           

        }
    }
}
