namespace happykids.Models.Address;

using System.ComponentModel.DataAnnotations;

public class UpdateReqAddress
{
    public int CustID { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    public string Region { get; set; }

    public string Postalcode { get; set; }

    public string Phone { get; set; }
    public char isAddress { get; set; }
}