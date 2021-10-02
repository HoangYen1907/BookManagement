using System.ComponentModel.DataAnnotations;

namespace BookManagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}