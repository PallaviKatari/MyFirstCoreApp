using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstCoreApp.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [Required]
        //[Required(ErrorMessage = "Kindly fill your Name")]
        //[StringLength(15, MinimumLength = 4, ErrorMessage = "Name does not satisfy the condition")]
        //[RegularExpression(@"^([A-Za-z]+)$")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Kindly fill your Designation")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Designation does not satisfy the condition")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Designation { get; set; }
    }
}
