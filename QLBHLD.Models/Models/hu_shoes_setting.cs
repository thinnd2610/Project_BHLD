﻿using QLBHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model.Models
{
    [Table("hu_shoes_setting")]
    public class hu_shoes_setting : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int gender { get; set; }

        //size bàn chân từ
        public int size_from { get; set; }
        
        //size bàn chân đến
        public int size_to { get; set; }
        
        //shoes size 
        [ForeignKey("size_id")]
        public int size_id { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
