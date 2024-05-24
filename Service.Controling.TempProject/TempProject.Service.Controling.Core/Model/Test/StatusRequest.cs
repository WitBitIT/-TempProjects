using System.ComponentModel.DataAnnotations;

namespace TempProject.Service.Controling.Core.Model.Test
{
    public class StatusRequest
    {
        [Display(Name = "NameStatus")]
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string? request { get; set; }
    }
}
