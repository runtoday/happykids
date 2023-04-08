namespace happykids.Entities;

  public class ProductEx
  {
    public virtual Product Product { get; set; }
    public virtual IEnumerable<ProductColor> ProductColor { get; set; }
  }