namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;

    public partial class DbModel : DbContext
    {
       

        public virtual DbSet<tblUser> Users { get; set; }
        public virtual DbSet<tblArticle> Articles { get; set; }


    }
}
