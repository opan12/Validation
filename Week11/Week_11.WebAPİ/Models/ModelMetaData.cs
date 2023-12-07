using System.ComponentModel.DataAnnotations;
namespace Week_11.WebAPİ.Models
{
    public class ModelMetaData
    {
        [Required(ErrorMessage = "First name can't be null")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name can't be null")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone number can't be null")]
        [Phone(ErrorMessage = "Phone number have to be well-formed")]
        public string PhoneNumber { get; set; }
    }
}
