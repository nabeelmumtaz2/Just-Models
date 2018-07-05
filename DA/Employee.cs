using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_Group_Corporation.Models //remove .da
{
    [MetadataType(typeof(employementMetaData))]
    public partial class Employee //make it partial 
    {

    }

    public class employementMetaData
    {
        [Required]
      
        [Display(Name = "Username:")]
        public string Username { get; set; }

        [Required]
      
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required]
       
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:")]
        public string EMail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Required]
       
        [Display(Name = "Role:")]
        public string Role { get; set; }

       
       
        [Display(Name = "Active:")]
        public bool Active { get; set; }

      
        
        public int PhoneExt { get; set; }
    }
}