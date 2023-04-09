
 namespace happykids.Entities;

  public class Address
  {
    public int addressID { get; set; }
    public int custID { get; set; }
    
    public string fname { get; set; }
    public string lname { get; set; }
    public string companyname { get; set; }
    public string address { get; set; }
    public string address2 { get; set; }
    public string city { get; set; }

    public string country { get; set; }

    public string region { get; set; }
    public string postalcode { get; set; }

    public string phone { get; set; }
    public char isAddress { get; set; }
  
  }