using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CodingEx.ViewModels
{
    public class ReceiptViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "write brief description for your receipt")]
        [StringLength(50)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Upload your receipt image here")]
        [Display(Name = "Receit File")]
        public IFormFile ReceiptImg { get; set; }

        public decimal Amount { get; set; }
    }
}
