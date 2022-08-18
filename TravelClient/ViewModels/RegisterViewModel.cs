using System.ComponentModel.DataAnnotations;

namespace TravelClient.ViewModels
{
  public class RegisterViewModel
  {
    
    [Required]
    [DataType(DataType.Text)]
    [Display(Name = "Username")]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }



  }
}