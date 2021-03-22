using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBookShop.ViewModels
{
    public class PaymentInfo
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$")]
        public string CardHolderName { get; set; }
        
        [Required]
        [StringLength(30)]
        public string CardNumber { get; set; }
        
        [Required]
        public string ExpiryMonth { get; set; }
        
        [Required]
        public string ExpiryYear { get; set; }
        
        [Required]
        [RegularExpression(@"^[0-9]{3,4}$")]
        public int CVV { get; set; }
    }
}
