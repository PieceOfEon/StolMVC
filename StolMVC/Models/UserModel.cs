using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StolMVC.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Поле 'ФИО' обязательно для заполнения")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Поле 'Возраст' обязательно для заполнения")]
        [Range(0, 150, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Поле 'Дата рождения' обязательно для заполнения")]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Поле 'Пароль' обязательно для заполнения")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Поле 'Пол' обязательно для выбора")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Поле 'Секретное слово' обязательно для выбора")]
        public string SecretWord { get; set; }

        [Required(ErrorMessage = "Поле 'Ответ на секретное слово' обязательно для заполнения")]
        [Display(Name = "Ответ на секретное слово")]
        public string SecretWordAnswer { get; set; }

        [Display(Name = "Фотография")]
        public IFormFile ProfileImage { get; set; } // Новое свойство для изображения

    }
}
