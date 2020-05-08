using Microsoft.AspNetCore.Http;
using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class EmployeeCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Employee Number is required"),
            RegularExpression("^[A-Z]{3,3}[0-9]{3}$")]
        public string EmployeeNo { get; set; }
        [Required(ErrorMessage ="First Number is required"), StringLength(50,MinimumLength =2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"),Display(Name="First Name")]
        public string FirstName { get; set; }
        [StringLength(50), Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Number is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName {
            get
            {
                return FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : (" " + (char?)MiddleName[0] + ".").ToUpper()) + LastName;
            }
        }
        public string Gender { get; set; }
        [Display(Name ="Photo")]
        public IFormFile ImageUrl { get; set; }
        [DataType(DataType.Date),Display(Name ="Date Of Birth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        [Required(ErrorMessage ="Job Role is required"),StringLength(100)]
        public string Designation { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(50),Display(Name ="PAN No."),
            RegularExpression(@"^[A-Za-z]{5}\d{4}[A-Za-z]{1}$")]
        
        public string PANCardNo { get; set; }
        [Display(Name="Payment Method")]
        public PaymehtMethod PaymehtMethod { get; set; }
        [Display(Name = "Student Loan")]
        public StudentLoan StudentLoan { get; set; }
        [Display(Name = "Union Member")]
        public UnionMember UnionMember { get; set; }
        [Required, StringLength(150)]
        public string Address { get; set; }
        [Required, StringLength(150)]
        public string City { get; set; }
        [Required, StringLength(50)]
        public string PostCode { get; set; }
    }
}
