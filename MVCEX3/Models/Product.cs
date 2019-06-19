using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEX3.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }


        // date [displayFormat()
    }
}