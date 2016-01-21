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
        public string Ordernamn { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string Leveransadress { get; set; }
        [MaxLength(30)]
        public string Stad { get; set; }
        [MaxLength(30)]
        public string Ort { get; set; }
        [MaxLength(30)]
        public string Postkod { get; set; }
        [MaxLength(250)]
        public string Kommentar { get; set; }

        public Customer CustomerID { get; set; }

    }
}