
namespace happykids.Models.Payment;


public class CreateReqPayment
{
    public int OrderId { get; set; }

    public int CustId { get; set; }

    public string CardNo { get; set; }

    public string CardName { get; set; }

    public string ExpireDate { get; set; }

    public string CvvCode { get; set; }

    public string CardType { get; set; }

    public char isSaveWallet { get; set; }

}