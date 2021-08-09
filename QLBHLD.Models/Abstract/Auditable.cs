﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [StringLength(1)]
       public string actflg { get; set; }

        [StringLength(255)]
        public string created_by { get; set; }

       public DateTime? created_date { get; set; }

        [StringLength(255)]
        public string created_log { get; set; }

        public DateTime? modified_date { get; set; }

        
    }
}
