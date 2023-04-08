namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;
using Microsoft.EntityFrameworkCore;

public interface IProductDetailService
{
    IEnumerable<ProductDetail> GetAll();
    IEnumerable<ProductDetail> GetById(int id);
}

public class ProductDetailService : IProductDetailService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public ProductDetailService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<ProductDetail> GetAll()
    {
        return _context.ProductDetail;
    }

    public IEnumerable<ProductDetail> GetById(int id)
    {
        return getProductDetail(id);
    }

    // helper methods

    private IEnumerable<ProductDetail> getProductDetail(int id)
    {
        var ProductDetail = _context.ProductDetail.Include(s=>s.Size).Where(s => s.ProductColorID == id);
        if (ProductDetail == null) throw new KeyNotFoundException("ProductDetail not found");
        return ProductDetail;
    }
}