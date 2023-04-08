namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;
using happykids.Models.Basket;

[ApiController]
[Route("[controller]")]
public class BasketController : ControllerBase
{
    private IBasketService _basketService;
    private IMapper _mapper;

    public BasketController(
        IBasketService basketService,
        IMapper mapper)
    {
        _basketService = basketService;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _basketService.GetById(id);
        return Ok(category);
    }

    [HttpPost]
    public IActionResult Create(CreateRequest model)
    {
        _basketService.Create(model);
        return Ok(new { message = "Basket created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, CreateRequest model)
    {
        _basketService.Update(id, model);
        return Ok(new { message = "Basket updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id,CreateRequest model)
    {
        _basketService.Delete(id,model);

        return Ok(new { message = "Basket deleted" });
    }
}