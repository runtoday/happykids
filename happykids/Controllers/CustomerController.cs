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

    [HttpPost]
    public IActionResult Create(CreateRequestCustomer model)
    {
        _customerService.Create(model);
        var customer =_customerService.GetByEmail(model.Email);
        return Ok(new { custID = customer.custID, email =customer.email});
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateRequestCustomer model)
    {
        _customerService.Update(id, model);
        return Ok(new { message = "Customer updated" });
    }
}