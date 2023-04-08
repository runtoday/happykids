namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;
using Microsoft.EntityFrameworkCore;

public interface IStoredProcedureService
{
    IEnumerable<StroedProduct> GetProductAll();
    ProductEx GetById(int id);
}

public class StoredProcedureService : IStoredProcedureService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public StoredProcedureService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<StroedProduct> GetProductAll()
    {
        return _context.SpGetProductAll();
    }

    public ProductEx GetById(int id)
    {
        return GetProductDetail(id);
    }

    private ProductEx GetProductDetail(int id)
    {
        var isProduct = _context.Product.Find(id);

        var isProductColor = _context.ProductColor.Include(c => c.Color).Where(c => c.productID == id);
  
       /* foreach(int k in isProductColor.ToList())
        {
            Console.Write("At Position {0}: ", p);
            Console.WriteLine(k);
            p++;
        }*/
  

        //var isProductDetail = _context.ProductDetail.Include(s => s.Size);
        //var isProductDetail = _context.ProductDetail.Include(s => s.ProductColor).Include(s => s.Size).Where(s=>s.ProductColor.productID == id);

        var ProductEx = new ProductEx {
            Product = isProduct,
            ProductColor = isProductColor,
            };

        if (ProductEx == null) throw new KeyNotFoundException("Product not found");
        return ProductEx;
    }

}