using Cache;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EditUserData
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Password { get; set; }
        public string PasswordConf { get; set; }

        public EditUserData(int id, string username, string firstname, string lastname, string email, string position,string pass,string passconf)
        {
            this.Id = id;
            this.UserName = username;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Position = position;
            this.Email = email;
            this.Password = pass;
            this.PasswordConf = passconf;
        }

        public void EditUser()
        {
            bool isValid = true;

            tblUser model = new tblUser();

            using (DbModel db = new DbModel())
            {
                if (db.Users.Any(x => x.UserName.Equals(this.UserName)) && ActiveUser.c_UserName != this.UserName)
                {
                    isValid = false;
                    throw new Exception("User name taken");
                }
                
                if (this.Password != this.PasswordConf)
                {
                     isValid = false;
                    throw new Exception("Password not match");
                }

                if (isValid == true)
                {
                   
                    ActiveUser.c_Id = Id;
                    ActiveUser.c_UserName = this.UserName;
                    ActiveUser.c_FirstName = this.FirstName;
                    ActiveUser.c_LastName = this.LastName;
                    ActiveUser.c_Email = this.Email;
                    ActiveUser.c_Position = this.Position;


                    // transfer cache to model
                    model.UserId = this.Id;
                    model.UserName = this.UserName;
                    model.FirstName = this.FirstName;
                    model.LastName = this.LastName;
                    model.Email = this.Email;
                    model.Position = this.Position;

                    if (this.Password != "" && this.PasswordConf != "" )     
                    {
                        if (this.Password == this.PasswordConf && this.Password != "")
                        {
                            ActiveUser.c_Password = this.Password;
                            model.Password = this.Password;
                        }
                    }
                    model.Password = ActiveUser.c_Password;

                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }

            }
        }
    }
}
