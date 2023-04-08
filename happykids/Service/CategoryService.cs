namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;

public interface ICategoryService
{
    IEnumerable<Category> GetAll();
    Category GetById(int id);
}

public class CategoryService : ICategoryService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public CategoryService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Category> GetAll()
    {
        return _context.Category;
    }

    public Category GetById(int id)
    {
        return getCategory(id);
    }
    public void Delete(int id)
    {
        var Category = getCategory(id);
        _context.Category.Remove(Category);
        _context.SaveChanges();
    }

    // helper methods

    private Category getCategory(int id)
    {
        var Category = _context.Category.Find(id);
        if (Category == null) throw new KeyNotFoundException("Category not found");
        return Category;
    }
}