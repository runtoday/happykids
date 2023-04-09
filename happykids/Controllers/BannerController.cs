namespace happykids.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using happykids.Services;

[ApiController]
[Route("[controller]")]
public class BannerController : ControllerBase
{
    private IBannerService _bannerService;
    private IMapper _mapper;

    public BannerController(
        IBannerService bannerService,
        IMapper mapper)
    {
        _bannerService = bannerService;
        _mapper = mapper;
    }


    [HttpGet]
    public IActionResult GetHome()
    {
        var banner = _bannerService.GetHome();
        return Ok(banner);
    }

    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var banner = _bannerService.GetById(id);
        return Ok(banner);
    }
}