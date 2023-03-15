using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_App_Patient.Model
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DisplayName("Zip Code")]
        public int ZipCode { get; set; }
        [Required]
        [DisplayName("Admit To")]
        public string AdmitTo { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
