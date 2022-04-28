using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogUsers.Models
{
    public class UsersModel
    {
        [Display(Name = "Возраст")]
        [Range(7, 70, ErrorMessage = "Вам необходимо вписать возраст от 7 до 70")]
        public int Age { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Необходимо заполнить поле имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Необходимо заполнить поле фамилия")]
        public string Surname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Необходимо заполнить поле email")]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Подтверждение Email")]
        [Compare("Email", ErrorMessage = "Подтверждение email неверное")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Необходимо заполнить поле пароль")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Пароль должен быть менее 50ти и более 4 символов")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Подтверждение пароля неверное")]
        public string ConfrimPassword { get; set; }
    }
}