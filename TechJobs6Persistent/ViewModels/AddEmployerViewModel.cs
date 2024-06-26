using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent;

public class AddEmployerViewModel
{
    [Required(ErrorMessage = "Name is Required.")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Location is Required.")]
    public string? Location { get; set; }
}
