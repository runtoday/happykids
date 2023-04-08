namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;

public interface IFilterService
{
    Filter GetAll();
}

public class FilterService : IFilterService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public FilterService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Filter GetAll()
    {
        return new Filter {
            Category = _context.Category,
            Color = _context.Color,
            Size = _context.Size       
            };
    }
}