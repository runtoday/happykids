namespace happykids.Entities;

  public class ProductColor
  {
    public int ProductColorID { get; set; }
    public int productID { get; set; }
    public byte[] image { get; set; }
    public virtual Color Color { get; set; }

  }