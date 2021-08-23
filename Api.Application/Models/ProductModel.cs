namespace Api.Application.Dtos
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}
