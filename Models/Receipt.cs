using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodingEx.Models
{
    public class Receipt
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Employee Name")]
        [StringLength(50)] 
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "write brief description for your receipt")]
        [StringLength(50)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        
        [Required(ErrorMessage = "Upload your receipt image here")]
        public string ReceiptImg { get; set; }

        public decimal Amount { get; set; }
    }
}
