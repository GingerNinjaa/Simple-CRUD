﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("tblPostion")]
   public  class tblPosition
    {
        [Key]
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }
}