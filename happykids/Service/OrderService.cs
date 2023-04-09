namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;
using happykids.Models.Order;
using Microsoft.EntityFrameworkCore;

public interface IOrderService
{
    Orders GetById(int id);
    int Create(CreateReqOrd model);  
}

public class OrderService : IOrderService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public OrderService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public Orders GetById(int id)
    {
        return getOrder(id);
    }


    public int Create(CreateReqOrd model)
    {

        // map model to new user object
        var Order = _mapper.Map<Orders>(model);

        // hash password
        //user.PasswordHash = BCrypt.HashPassword(model.Password);

        // save user
        _context.Orders.Add(Order);

        _context.SaveChanges();
        return Order.orderID;
    }


    // helper methods
    private Orders getOrder(int id)
    {
        //var Customer = _context.Customer.FirstOrDefault( c => c.custID == id);
        var Order = _context.Orders.Find(id);
        if (Order == null) throw new KeyNotFoundException("Order not found");
        return Order;
    }
}