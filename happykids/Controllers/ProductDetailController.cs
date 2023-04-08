namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;

[ApiController]
[Route("[controller]")]
public class ProductDetailController : ControllerBase
{
    private IProductDetailService _ProductDetail;
    private IMapper _mapper;

    public ProductDetailController(
        IProductDetailService ProductDetail,
        IMapper mapper)
    {
        _ProductDetail = ProductDetail;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetProductAll()
    {
        var StoredProcedure = _ProductDetail.GetAll();
        return Ok(StoredProcedure);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _ProductDetail.GetById(id);
        return Ok(category);
    }
}