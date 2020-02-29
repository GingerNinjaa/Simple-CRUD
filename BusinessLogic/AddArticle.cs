using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public  class AddArticle
    {
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }
        public Decimal Price { get; set; }
        public string ArticleCategory { get; set; }

        public AddArticle(string articlename, string description, decimal price, string articlecategory)
        {
            this.ArticleName = articlename;
            this.ArticleDescription = description;
            this.Price = price;
            this.ArticleCategory = articlecategory;
        }

        public void NewArticle()
        {         
            tblArticle model = new tblArticle();

            using (DbModel db = new DbModel())
            {
                model.ArticleName = this.ArticleName;
                model.ArticleDescription = this.ArticleDescription;
                model.Price = this.Price;
                model.ArticleCategory = this.ArticleCategory;

                db.Articles.Add(model);
                db.SaveChanges();
            }
        }

    }
}
