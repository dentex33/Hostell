using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hostell.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name ="Имя пользователя")]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Пароли не совпадают.")]
        [DataType(DataType.Password)]
        [Display(Name ="Подтвердите пароль")]
        public string PasswordConfirm { get; set; }
    }
}
