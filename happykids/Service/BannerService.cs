namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;

public interface IBannerService
{
    IEnumerable<Banner> GetHome();
    Banner GetById(int id);
}

public class BannerService : IBannerService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public BannerService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Banner> GetHome()
    {
        return _context.Banner.Take(3);
    }

    public Banner GetById(int id)
    {
        return getBanner(id);
    }
    // helper methods

    private Banner getBanner(int id)
    {
        var Color = _context.Banner.Find(id);
        if (Color == null) throw new KeyNotFoundException("Banner not found");
        return Color;
    }
}