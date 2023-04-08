namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;

[ApiController]
[Route("[controller]")]
public class StoredProcedureController : ControllerBase
{
    private IStoredProcedureService _StoredProcedure;
    private IMapper _mapper;

    public StoredProcedureController(
        IStoredProcedureService StoredProcedure,
        IMapper mapper)
    {
        _StoredProcedure = StoredProcedure;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetProductAll()
    {
        var StoredProcedure = _StoredProcedure.GetProductAll();
        return Ok(StoredProcedure);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _StoredProcedure.GetById(id);
        return Ok(category);
    }
}