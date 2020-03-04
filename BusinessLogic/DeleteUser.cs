using Cache;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DeleteUser
    {
        public int Id { get; set; }
        public DeleteUser(int id)
        {
            this.Id = id;
        }

        public void Delete()
        {
            tblUser model = new tblUser();
            //admin

            using (DbModel db = new DbModel())
            {

                model = db.Users.Where(x => x.UserId == this.Id).FirstOrDefault();

                if (ActiveUser.c_Position == "GM")
                {
                    db.Users.Remove(model);
                    db.SaveChanges();
                }

                if (model.Position != "admin" && ActiveUser.c_Position != "GM")
                {
                    db.Users.Remove(model);
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
