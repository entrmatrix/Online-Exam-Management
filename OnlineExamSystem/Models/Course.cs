using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineExamSystem.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please provide a name using 3-50 characters!")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Code length must be atleast 8 characters!")]
        [DataType(DataType.Text)]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please provide the duration of your course!")]
        [DataType(DataType.Duration)]
        public double Duration { get; set; }
        [Required(ErrorMessage = "Please provide the credit of your course!")]
        public int Credit { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 20, ErrorMessage = "Please provide outline of your course with minimum 20 characters!")]
        [DataType(DataType.MultilineText)]
        public string Outline { get; set; }
        [Required(ErrorMessage = "Please provide the fees of your course!")]
        [DataType(DataType.Currency)]
        public double Fees { get; set; }
        [Required]
        [ForeignKey("OrganizationId")]
        public int OrganizationId { get; set; }
        
        

       
    
}
}