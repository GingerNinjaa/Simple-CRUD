using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class tblArticle
    {
        [Key]
        public int ArticleId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ArticleName { get; set; }
        [Required]
        public string ArticleDescription { get; set; }
        [Required]
        public Decimal Price { get; set; }
        [Required]
        [MaxLength(50)]
        public string ArticleCategory { get; set; }

    }
}
