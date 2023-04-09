namespace happykids.Models.Order;


public class CreateReqOrd
{
    public int CustId { get; set; }

    public int AddressId { get; set; }

    public double ShippingFee { get; set; }

    public double TotalAmount { get; set; }

    public string CouponCode { get; set; }

    public string Note { get; set; }

}