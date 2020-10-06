using System.ComponentModel.DataAnnotations;

namespace CourseApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Od 4 do 8 karaktera!")]
        public string Password { get; set; }
    }
}