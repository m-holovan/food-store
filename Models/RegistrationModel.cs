using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace food_store.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Enter Name")]
        [StringLength(30, MinimumLength = 2)]
        public string userName { get; set; }
        [Required(ErrorMessage = "Enter E-mail")]
        [EmailAddress]
        [UIHint("EmailAddress")]
        public string userEmail { get; set; }
        [Required(ErrorMessage = "Enter Date")]
        [UIHint("Date")]
        public string userDate { get; set; }
        [Required(ErrorMessage = "Enter Time")]
        [UIHint("Time")]
        public string userTime { get; set; }
        [Required(ErrorMessage = "Enter Value")]
        public string peopleValue { get; set; }
    }
}
