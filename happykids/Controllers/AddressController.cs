namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;
using happykids.Models.Address;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private IAddressService _addressService;
    private IMapper _mapper;

    public AddressController(
        IAddressService addressService,
        IMapper mapper)
    {
        _addressService = addressService;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var address = _addressService.GetById(id);
        return Ok(address);
    }

    [HttpPost]
    public IActionResult Create(CreateReqAddress model)
    {
        int id = _addressService.Create(model);

        return Ok(new { AddressId = id,
                       message = "address created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateReqAddress model)
    {
        _addressService.Update(id, model);
        return Ok(new { message = "address updated" });
    }
}