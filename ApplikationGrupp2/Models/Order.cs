using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikationGrupp2.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [MaxLength(30)]
        public string OrderName { get; set; }


        public Customer CustomerID { get; set; }

    }
}