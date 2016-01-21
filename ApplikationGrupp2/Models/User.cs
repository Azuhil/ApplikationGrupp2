using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikationGrupp2.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
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
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        [DisplayName("Username")]
        public string UserName { get; set; }
        [Required]
        [MaxLength(12)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }
    }
}