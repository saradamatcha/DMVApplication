using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DMVApplication.Models
{
    public class PaymentDetails
    {
        [Required]
        [RegularExpression("^[0-9]{12,12}$", ErrorMessage = "Enter only numeric number")]
        public int CreditCardID { get; set; }

        [Required]
        public string CardHolderName { get; set; }

        [Required]     
        public DateTime ExpirateDate { get; set; }
        public string LicenceID { get; set; }
    }

    public enum Status
    {

        Request = 0,
        Pending = 1,
        Approve = 2
    };

    public class PaymentInfo
    {
        public string LicenceID { get; set; }
        public Status ApplicationStatus { get; set; }
    }


}