namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;
using happykids.Models.Order;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private IOrderService _orderService;
    private IMapper _mapper;

    public OrderController(
        IOrderService orderService,
        IMapper mapper)
    {
        _orderService = orderService;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var order = _orderService.GetById(id);
        return Ok(order);
    }

    [HttpPost]
    public IActionResult Create(CreateReqOrd model)
    {
        int id = _orderService.Create(model);

        return Ok(new { OrderId = id,
                       message = "Order created" });
    }
}