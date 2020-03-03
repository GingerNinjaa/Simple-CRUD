using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  public class DelArticle
    {
        public int Id { get; set; }

        public DelArticle(int id)
        {
            this.Id = id;
        }

        public void Delete()
        {
            tblArticle model = new tblArticle();

            using (DbModel db = new DbModel())
            {
                model = db.Articles.Where(x => x.ArticleId == this.Id).FirstOrDefault();

                db.Articles.Remove(model);
                db.SaveChanges();

            }
        }
    }
}
