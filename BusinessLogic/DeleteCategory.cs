using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DeleteCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public DeleteCategory( string categoryname)
        {  
            this.CategoryName = categoryname;
        }

        public void Delete()
        {
            tblCategory model = new tblCategory();

            using (DbModel db = new DbModel())
            {

               this.Id = db.Categories.Where(x => x.CategoryName == this.CategoryName).Select(x => x.CategoryId).FirstOrDefault();


                model.CategoryId = this.Id;
                model.CategoryName = this.CategoryName;


                db.Categories.Attach(model);
                db.Categories.Remove(model);
                db.SaveChanges();

            }

        }

    }
}
