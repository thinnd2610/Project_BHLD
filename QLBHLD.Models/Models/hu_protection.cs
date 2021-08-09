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
    [Table("hu_protection")]
    public class hu_protection : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //Mã bảo hộ
        [StringLength(50)]
        public string code { get; set; }

        //Tên bảo hộ
        [StringLength(255)]
        public string protection_name { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
