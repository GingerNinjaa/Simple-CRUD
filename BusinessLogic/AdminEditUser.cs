﻿using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AdminEditUser
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConf { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public AdminEditUser(string username, string pass, string passconf, string firstname, string lastname, string position, string email)
        {

            this.UserName = username;
            this.UserName = username;
            this.Password = pass;
            this.PasswordConf = passconf;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Position = position;
            this.Email = email;

            // else //edit
            //{
            //    db.Entry(model).State = EntityState.Modified;
            //}
        }

        public void EditUser()
        {
            bool isValid = true;

            tblUser model = new tblUser();

            using (DbModel db = new DbModel())
            {
                if (db.Users.Any(x => x.UserName.Equals(this.UserName)))
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

                    model.UserId = db.Users.Where(x => x.UserName == this.UserName).Select(x => x.UserId).FirstOrDefault();
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
    }
}
