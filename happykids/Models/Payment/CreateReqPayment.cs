
namespace happykids.Models.Payment;
using System.ComponentModel.DataAnnotations;

public class CreateReqPayment
{    
    [Required]
    public int OrderId { get; set; }

    [Required]
    public int CustId { get; set; }

    [Required]
    [MaxLength(16)]
    public string CardNo { get; set; }

    public string CardName { get; set; }

    [Required]
    [MaxLength(5)]
    public string ExpireDate { get; set; }

    [Required]
    [MaxLength(3)]
    public string CvvCode { get; set; }

    [Required]
    public string CardType { get; set; }

    public char isSaveWallet { get; set; }

}