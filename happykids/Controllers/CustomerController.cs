namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;
using happykids.Models.Customer;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private ICustomerService _customerService;
    
    private IMapper _mapper;

    public CustomerController(
        ICustomerService customerService,
        IMapper mapper)
    {
        _customerService = customerService;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var customer = _customerService.GetById(id);
        return Ok(customer);
    }

    [HttpGet("{id/Order}")]
    public IActionResult GetByCustId(int id)
    {
        var order = _customerService.GetByCustId(id);
        return Ok(order);
    }

    [HttpPost]
    public IActionResult Create(CreateRequestCustomer model)
    {   
        int id = _customerService.Create(model);
        return Ok(new { custID = id, email =model.Email});
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateRequestCustomer model)
    {
        _customerService.Update(id, model);
        return Ok(new { message = "Customer updated" });
    }
}