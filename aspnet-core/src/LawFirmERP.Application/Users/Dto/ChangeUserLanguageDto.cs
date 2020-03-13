using System.ComponentModel.DataAnnotations;

namespace LawFirmERP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}