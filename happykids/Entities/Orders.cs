namespace happykids.Entities;


  public class Orders
  {
    public int orderID { get; set; }

    public string orderDate { get; set; }
    
    public int custID { get; set; }
    
    public string addressID { get; set; }
    
    public string shippingID { get; set; }
    
    public double shippingFee { get; set; }

    public double totalAmount { get; set; }
    public string couponCode { get; set; }
    public string note { get; set; }
    public char isPayment { get; set; }
    public char isTransport { get; set; }

    public char  isComplete { get; set; }
  }