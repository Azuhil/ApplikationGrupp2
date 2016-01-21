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
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Namn { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Text")]
        public string Beskrivning { get; set; }

        public OrderItem OrderItemID { get; set; }
    }
}