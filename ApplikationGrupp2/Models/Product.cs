using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikationGrupp2.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [MaxLength(250)]
        [Column(TypeName = "nvarchar")]
        public string Comment { get; set; }

        public OrderItem OrderItemID { get; set; }
    }
}