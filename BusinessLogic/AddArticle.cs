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
        public bool Valid { get; set; }
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

                AddNewCategory();

                db.Articles.Add(model);
                db.SaveChanges();
            }
        }

        public void EditArticle()
        {
            tblArticle model = new tblArticle();

            using (DbModel db = new DbModel())
            {
                model.ArticleId = db.Articles.Where(x => x.ArticleName == this.ArticleName).Select(x => x.ArticleId).FirstOrDefault();
                model.ArticleName = this.ArticleName;
                model.ArticleDescription = this.ArticleDescription;
                model.Price = this.Price;
                model.ArticleCategory = this.ArticleCategory;

                if (!db.Categories.Any(x => x.CategoryName == this.ArticleCategory))
                {
                    AddNewCategory();
                }

                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Add_or_edit()
        {
            using (DbModel db = new DbModel())
            {
                Valid = db.Articles.Any(x => x.ArticleName == this.ArticleName);
            }

            if (Valid != true)
            {
                NewArticle();
            }
            else
            {
                EditArticle();
            }

        }

        public void AddNewCategory()
        {
            using (DbModel db = new DbModel())
            {
                tblCategory model = new tblCategory();

                if (!db.Categories.Any(x => x.CategoryName.Equals(this.ArticleCategory)))
                {
                    model.CategoryName = this.ArticleCategory;

                    db.Categories.Add(model);
                    db.SaveChanges();
                }
            }

        }

    }
}
