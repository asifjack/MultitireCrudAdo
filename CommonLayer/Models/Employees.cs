using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CommonLayer.Models
{
    public class Employees
    {
     
        public int Id { get; set; }

        [Display(Name="Employee FirstName")]
        [Required(ErrorMessage="Employee FirstName Can't Be Empty")]
       
        public string FirstName { get; set; }

        [Display(Name = "Employee LastName")]
        [Required(ErrorMessage = "Employee LastName Can't Be Empty")]
      
        public string LastName { get; set; }

        [Display(Name = "Employee Email Required")]
        [Required(ErrorMessage = "Employee Email Can't Be Empty")]
        public string Email { get; set; }

        [Display(Name = "Gender Email Required")]
        [Required(ErrorMessage = "Gender Email Can't Be Empty")]
        public string Gender { get; set; }
    }
}
