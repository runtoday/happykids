namespace happykids.Models.Order;
using System.ComponentModel.DataAnnotations;

public class CreateReqOrd
{
    [Required]
    public int CustId { get; set; }
    
    [Required]
    public int AddressId { get; set; }

    public double ShippingFee { get; set; }

    public double TotalAmount { get; set; }

    public string CouponCode { get; set; }

    public string Note { get; set; }

}