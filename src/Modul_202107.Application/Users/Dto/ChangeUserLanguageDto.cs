using System.ComponentModel.DataAnnotations;

namespace Modul_202107.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}