namespace First.WebApi.Models
{
    public class Product:Entity
    {
       
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}
