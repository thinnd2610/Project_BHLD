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
    [Table("hu_district")]
    public class hu_district: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(255)]
        public string district_name { get; set; }

        //[ForeignKey("province_id")]
        public int province_id { get; set; }

        //ghi chú
        [StringLength(1023)]
        public string remark { get; set; }
    }
}
