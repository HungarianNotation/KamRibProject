using System.ComponentModel.DataAnnotations;

namespace KamRib.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string StoreIds { get; set; }
    }
}
