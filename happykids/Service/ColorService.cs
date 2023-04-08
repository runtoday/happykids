namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;

public interface IColorService
{
    IEnumerable<Color> GetAll();
    Color GetById(int id);
}

public class ColorService : IColorService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public ColorService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Color> GetAll()
    {
        return _context.Color;
    }

    public Color GetById(int id)
    {
        return getColor(id);
    }
    public void Delete(int id)
    {
        var Color = getColor(id);
        _context.Color.Remove(Color);
        _context.SaveChanges();
    }

    // helper methods

    private Color getColor(int id)
    {
        var Color = _context.Color.Find(id);
        if (Color == null) throw new KeyNotFoundException("Color not found");
        return Color;
    }
}