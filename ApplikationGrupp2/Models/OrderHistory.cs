using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikationGrupp2.Models
{
    public class OrderHistory
    {
        [Key]
        public int OrderHistorikID { get; set; }
        [Column(TypeName = "varchar")]
        public string OrderSkickad { get; set; } 

        public Order OrderID { get; set; }

    }
}