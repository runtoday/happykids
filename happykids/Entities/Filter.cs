  namespace happykids.Entities;

  public class Filter
  {
    public virtual IEnumerable<Category> Category { get; set; }
    public virtual IEnumerable<Color> Color { get; set; }
    public virtual IEnumerable<Size> Size { get; set; }
  }