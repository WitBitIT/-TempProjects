using System.ComponentModel.DataAnnotations;

namespace TempProject.Service.Controling.Core.Model.Test
{
    public class StatusRequest
    {
        [Display(Name = "NameStatus")]
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Display(Name = "DescriptionStatus")]
        [Required]
        [MinLength(0)]
        [MaxLength(45)]
        public string? Description { get; set; }
    }
}
