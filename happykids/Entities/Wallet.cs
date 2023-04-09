namespace happykids.Entities;

  public class Wallet
  {
    public int walletID { get; set; }

    public int custID { get; set; }

    public string cardNo { get; set; }

    public string cardName { get; set; }

    public string expireDate { get; set; }

    public string cvvCode { get; set; }

    public string cardType { get; set; }
    public char  isDefault { get; set; }
  }