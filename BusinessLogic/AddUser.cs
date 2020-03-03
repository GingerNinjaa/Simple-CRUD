using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AddUser
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConf { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        private bool Valid { get; set; }

        public AddUser( int id ,string username, string pass, string passconf, string firstname, string lastname, string position, string email)
        {
            this.id = id;
            this.UserName = username;
            this.UserName = username;
            this.Password = pass;
            this.PasswordConf = passconf;
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

                    //model.UserId = db.Users.Where(x => x.UserName == this.UserName).Select(x => x.UserId).FirstOrDefault();
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

        public void EditUser()
        {
            bool isValid = true;

            tblUser model = new tblUser();

            using (DbModel db = new DbModel())
            {
                //(db.Users.Any(x => x.UserName.Equals(this.UserName)))
                //(db.Users.Any((x => x.UserName == UserName && x.UserId != this.id))
                if(db.Users.Any((x => x.UserName == UserName && x.UserId != this.id)))
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
                    
                    
                    //this.id = db.Users
                    //            .Where(x => x.UserName.Equals(this.UserName))
                    //            .Select(x => x.UserId).FirstOrDefault();

                    model.UserId = this.id;

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


                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
        }

        public void Add_or_Edit()
        {
            using (DbModel db = new DbModel())
            {
                //   this.id = db.Users.Where(x => x.UserName == this.UserName).Select(x => x.UserId).FirstOrDefault();
                
                //valid = db.Users.Any(x => x.UserName == this.UserName);
                Valid = db.Users.Any((x => x.UserName == UserName && x.UserId != this.id));
            }

            if (Valid != true)
            {
                AddNewUser();
            }
            else
            {
                EditUser();
            }

        }
    }
}
