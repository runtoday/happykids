namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;

[ApiController]
[Route("[controller]")]
public class ProductServiceController : ControllerBase
{
    private IProductService _productService;
    private IMapper _mapper;

    public ProductServiceController(
        IProductService productService,
        IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetProductAll()
    {
        var StoredProcedure = _productService.GetProductAll();
        return Ok(StoredProcedure);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _productService.GetById(id);
        return Ok(category);
    }
}