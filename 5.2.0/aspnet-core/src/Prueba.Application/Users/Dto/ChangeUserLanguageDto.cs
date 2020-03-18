using System.ComponentModel.DataAnnotations;

namespace Prueba.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}