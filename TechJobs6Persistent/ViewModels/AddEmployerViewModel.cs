using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent;

public class AddEmployerViewModel
{
    [Required(ErrorMessage = "Name is Required.")]
    [StringLength(50, MinimumLength =3, ErrorMessage ="Name should be between 3 and 50 characters.")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Location is Required.")]
    [StringLength(50, MinimumLength =3, ErrorMessage ="Location should be between 3 and 50 characters.")]
    public string? Location { get; set; }
}
