namespace happykids.Models.Basket;

using System.ComponentModel.DataAnnotations;

public class CreateRequest
{
    [Required]
    public int custID { get; set; }

    [Required]
    public int productDetailID { get; set; }

    [Required]
    public int amount { get; set; }
}