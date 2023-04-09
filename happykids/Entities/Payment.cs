namespace happykids.Entities;

  public class Payment
  {
    public int paymentID { get; set; }

    public string paymentDate { get; set; }
    public int orderID { get; set; }

    public int custID { get; set; }

    public string cardNo { get; set; }

    public string cardName { get; set; }

    public string expireDate { get; set; }

    public string cvvCode { get; set; }

    public string cardType { get; set; }
  }