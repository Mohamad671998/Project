using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
      public class SignUp{

[Required(ErrorMessage = "Please enter Name")] 
        public string AccountName { get; set; }

[Required(ErrorMessage = "Please enter Phonenumber")] 
        public int Phonenumber  { get; set; }

[Required(ErrorMessage = "Please enter Password")] 
        public string Password { get; set; }


    }
}