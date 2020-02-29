using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class AddUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConf { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public AddUser(string username, string pass, string passconf, string firstname, string lastname, string position, string email)
        {
            this.UserName = username;
            this.Password = pass;
            this.PasswordConf = pass;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Position = position;
            this.Email = email;
        }

        public void AddNewUser()
        {
            bool isValid = true;

            using (DbModel db = new DbModel())
            {
                if (db.Users.Any(x => x.UserName.Equals(this.UserName)))
                {
                    isValid = false;
                    throw new Exception("UserName is taken");
                }


                if (this.Password != this.PasswordConf)
                {
                    isValid = false;
                    throw new Exception("Password not match");
                }
                if (this.Password == "" && this.PasswordConf == "")
                {
                    isValid = false;
                    throw new Exception("Incorect passwod");
                }

                if (isValid == true)
                {
                    tblUser model = new tblUser();

                    model.UserName = this.UserName;
                    model.FirstName = this.FirstName;
                    model.LastName = this.LastName;
                    model.Email = this.Email;      
                    model.Position = this.Position;

                    if (this.Password != "" && this.PasswordConf != "")
                    {
                        if (this.Password == this.PasswordConf && this.Password != "")
                        {                          
                            model.Password = this.Password;
                        }
                    }
                    db.Users.Add(model);
                    db.SaveChanges();
                }
            }
        }
    }
}
