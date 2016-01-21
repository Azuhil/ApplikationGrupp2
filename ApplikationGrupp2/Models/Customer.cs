using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikationGrupp2.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        [DisplayName("Email Adress")]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
    }
}