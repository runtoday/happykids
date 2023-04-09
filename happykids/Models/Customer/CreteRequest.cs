namespace happykids.Models.Customer;

using System.ComponentModel.DataAnnotations;

public class CreateRequestCustomer
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }
}