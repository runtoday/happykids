namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;
using happykids.Models.Customer;
using Microsoft.EntityFrameworkCore;

public interface ICustomerService
{
    Customer GetById(int id);
    void Create(CreateRequestCustomer model);
    void Update(int id, UpdateRequestCustomer model);

    public Customer GetByEmail(string email);
}

public class CustomerService : ICustomerService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public CustomerService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public Customer GetById(int id)
    {
        return getCustomer(id);
    }

    
    public Customer GetByEmail(string email)
    {
        return _context.Customer.SingleOrDefault(c => c.email == email);
    }


    public void Create(CreateRequestCustomer model)
    {
        // validate
        if (_context.Customer.Any(x => (x.email == model.Email)))
            throw new AppException("Customer with the Email '" + model.Email + "' already exists");

        // map model to new user object
        var Customer = _mapper.Map<Customer>(model);

        // hash password
        //user.PasswordHash = BCrypt.HashPassword(model.Password);

        // save user
        _context.Customer.Add(Customer);
        _context.SaveChanges();
    }

    public void Update(int id, UpdateRequestCustomer model)
    {
        var Customer = getCustomer(id);

        // copy model to user and save
        _mapper.Map(model, Customer);
        _context.Customer.Update(Customer);
        _context.SaveChanges();
    }

    // helper methods
    private Customer getCustomer(int id)
    {
        //var Customer = _context.Customer.FirstOrDefault( c => c.custID == id);
        var Customer = _context.Customer.Find(id);
        if (Customer == null) throw new KeyNotFoundException("Customer not found");
        return Customer;
    }
}