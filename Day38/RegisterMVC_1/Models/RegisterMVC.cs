using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisterMVC_1.Models
{
    public class RegisterMVC
    {
        [Required(ErrorMessage = "Id Is Required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserName Is Required")]
        [MaxLength(20, ErrorMessage = "UserName have should not have more than 20 character")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("Password",ErrorMessage ="Password Does Not Match")]       
        public string CPassword { get; set; }


        [Required(ErrorMessage ="Email Id Is Required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Enter Valid Email Address")]
        public string Email { get; set; }



        [Required(ErrorMessage = "City Is Required")]
        [RegularExpression("^[a-zA-Z]*$",ErrorMessage ="City Contain Only Alphabets")]
        public string City { get; set; }

        
    }
}