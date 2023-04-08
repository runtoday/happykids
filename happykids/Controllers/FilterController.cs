namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;

[ApiController]
[Route("[controller]")]
public class FilterController : ControllerBase
{
    private IFilterService _filterService;
    private IMapper _mapper;

    public FilterController(
        IFilterService filterService,
        IMapper mapper)
    {
        _filterService = filterService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var filter = _filterService.GetAll();
        return Ok(filter);
    }
}