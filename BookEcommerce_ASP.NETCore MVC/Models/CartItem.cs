using ClassLibrary_RepositoryDLL.Entities;
using System.ComponentModel.DataAnnotations;

namespace BookEcommerce_ASP.NETCore_MVC.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int CartId { get; set; }
        public int BookId { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual Book Book { get; set; }
        public virtual Cart Cart { get; set; }
    }
}