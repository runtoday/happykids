namespace happykids.Entities;

  public class ProductDetail
  {
    public int ProductDetailID { get; set; }
    public int ProductColorID { get; set; }
    
    public virtual Size Size { get; set; }
  }