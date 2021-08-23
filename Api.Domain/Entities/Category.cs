using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entitys
{
    public class Category : Base
    {
        public Category()
        {
            this.Products = new  List<Product>();
        }

        public string Title { get; set; }
        public double Margin { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
