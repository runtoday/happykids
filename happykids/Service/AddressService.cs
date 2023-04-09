namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;
using happykids.Models.Address;
using Microsoft.EntityFrameworkCore;

public interface IAddressService
{
    Address GetById(int id);
    int Create(CreateReqAddress model);
    void Update(int id, UpdateReqAddress model);
}

public class AddressService : IAddressService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public AddressService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public Address GetById(int id)
    {
        return getAddress(id);
    }

    public int Create(CreateReqAddress model)
    {
        // validate

        // map model to new user object
        var Address = _mapper.Map<Address>(model);

        // hash password
        //user.PasswordHash = BCrypt.HashPassword(model.Password);

        // save user
        _context.Address.Add(Address);
        _context.SaveChanges();
        return Address.addressID;
    }

    public void Update(int id,UpdateReqAddress  model)
    {
        var Address = getAddress(id);

        // copy model to user and save
        _mapper.Map(model, Address);
        _context.Address.Update(Address);
        _context.SaveChanges();
    }

    // helper methods
    private Address getAddress(int id)
    {
        //var Customer = _context.Customer.FirstOrDefault( c => c.custID == id);
        var Address = _context.Address.Find(id);
        if (Address == null) throw new KeyNotFoundException("Address not found");
        return Address;
    }
}