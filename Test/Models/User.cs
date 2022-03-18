using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email пользователя не установлен.")]
        [EmailAddress(ErrorMessage = "Некорректный email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Логин пользователя не установлен.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Пароль пользователя не установлен.")]
        [MinLength(6, ErrorMessage = "Пароль пользователя должен быть не менее 6-ти символов.")]
        public string Password { get; set; }

        [Phone(ErrorMessage = "Некорректный номер телефона.")]
        public string Phone { get; set; }

        public string Name { get; set; }
        public bool IsAdmin { get; set; } = false;
    }
}