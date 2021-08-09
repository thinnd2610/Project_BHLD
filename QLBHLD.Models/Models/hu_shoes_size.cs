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
    [Table("hu_shoes_size")]
    public class hu_shoes_size : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }


        //tên size giày
        //eg: 36,37,38,...
        [StringLength(255)]
        public string size_name { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
