using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace passport_validation_task.Models
{
    public class PassPort
    {
        [Required(ErrorMessage = "Please enter Passport Sereis/Пожалуйста, введите серию паспорта")]
        [Display(Name = "PassPort Series/Паспорт Серии")]
        [RegularExpression(@"([a-zA-z]{1,2})", ErrorMessage = "The PassPort Series is not entered in a correct format, Please Enter Aplhabets only")]
        [StringLength(2)]
        public string passSeries { get; set; }

        [Required(ErrorMessage = "Please enter Passport Number/Пожалуйста, введите номер паспорта")]
        [Display(Name = "PassPort Number/номер паспорта")]
        [RegularExpression(@"([A-Za-z0-9]{5,7})", ErrorMessage = "The PassPort Number is not entered in a correct format")]
        [StringLength(7)]
        public string passNumber { get; set; }

        public string fullPassport { get; set; }

     
    }
}
