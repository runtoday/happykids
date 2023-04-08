namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;

public interface ISizeService
{
    IEnumerable<Size> GetAll();
    Size GetById(int id);
}

public class SizeService : ISizeService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public SizeService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Size> GetAll()
    {
        return _context.Size;
    }

    public Size GetById(int id)
    {
        return getSize(id);
    }
    public void Delete(int id)
    {
        var Size = getSize(id);
        _context.Size.Remove(Size);
        _context.SaveChanges();
    }

    // helper methods

    private Size getSize(int id)
    {
        var Size = _context.Size.Find(id);
        if (Size == null) throw new KeyNotFoundException("Size not found");
        return Size;
    }
}