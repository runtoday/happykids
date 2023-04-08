namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private ICategoryService _categoryService;
    private IMapper _mapper;

    public CategoryController(
        ICategoryService categoryService,
        IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var category = _categoryService.GetAll();
        return Ok(category);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _categoryService.GetById(id);
        return Ok(category);
    }
}