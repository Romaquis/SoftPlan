using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entitys
{
    public class Product : Base
    {
        
        public string Description { get; set; }

        
        public double Price { get; set; }
        public DateTime RegistrerDate { get; set; }
        
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "*")]
        public Category Category { get; set; }
    }
}
