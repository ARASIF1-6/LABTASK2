using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabTask2.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [Range(1, 100)]
        public int price { get; set; }

        [Required]
        [Range(1, 100)]
        public int quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string category { get; set; }
        public string production_date { get; set; }
        public Boolean is_disposeable { get; set; }
        public string helpline { get; set; }
        public string support_mail { get; set; }
        
    }
}