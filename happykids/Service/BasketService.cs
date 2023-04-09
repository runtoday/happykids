namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;
using happykids.Models.Basket;
using Microsoft.EntityFrameworkCore;

public interface IBasketService
{
    IEnumerable<Basket> GetById(int id);
    void Create(CreateRequest model);
    public void Update(int id, CreateRequest model);
    public void Delete(int custID,CreateRequest model);
}

public class BasketService : IBasketService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public BasketService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Basket> GetAll()
    {
        return _context.Basket;
    }

    public IEnumerable<Basket> GetById(int id)
    {
        return getBasketByCust(id);
    }

    public void Create(CreateRequest model)
    {
        // validate
        if (_context.Basket.Any(x => (x.custID == model.custID) && (x.productDetailID == model.productDetailID) ))
            throw new AppException("Basket with the productDetailID '" + model.productDetailID + "' already exists");

        // map model to new user object
        var Basket = _mapper.Map<Basket>(model);

        // hash password
        //user.PasswordHash = BCrypt.HashPassword(model.Password);

        // save user
        _context.Basket.Add(Basket);
        _context.SaveChanges();
    }

    public void Update(int id, CreateRequest model)
    {
        var Basket = getBasket(model.custID,model.productDetailID);

        // Basket.amount = model.amount;
        // copy model to user and save
        _mapper.Map(model, Basket);
        _context.Basket.Update(Basket);

        _context.SaveChanges();
    }

    public void Delete(int custID,CreateRequest model)
    {
        //var Basket = _context.Basket.Where(b => (b.custID == id && b.productDetailID == productDetailID));
        var Basket = getBasket(custID,model.productDetailID);
        _context.Basket.Remove(Basket);
        _context.SaveChanges();
    }

    // helper methods
    private Basket getBasket(int custID,int productDetailID)
    {
        var Basket = _context.Basket.Find(custID,productDetailID);
        if (Basket == null) throw new KeyNotFoundException("Basket not found");
        return Basket;
    }

    private IEnumerable<Basket> getBasketByCust(int id)
    {
        var Basket = _context.Basket.Where(b => b.custID == id);
        if (Basket == null) throw new KeyNotFoundException("Basket not found");
        return Basket;
    }
}