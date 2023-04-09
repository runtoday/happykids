namespace happykids.Models.Customer;

using System.ComponentModel.DataAnnotations;
using happykids.Entities;

public class UpdateRequestCustomer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
}