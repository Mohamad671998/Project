using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please enter Name")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enterPassword")] 
        public string Password { get; set; }
    }
}