namespace happykids.Services;

using AutoMapper;
using happykids.Entities;
using happykids.Helpers;
using happykids.Models.Payment;
using Microsoft.EntityFrameworkCore;

public interface IPaymentService
{
    Payment GetById(int id);
    int Create(CreateReqPayment model);  
}

public class PaymentService : IPaymentService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public PaymentService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public Payment GetById(int id)
    {
        return getPayment(id);
    }


    public int Create(CreateReqPayment model)
    {

        // map model to new user object
        var Payment = _mapper.Map<Payment>(model);

        // hash password
        //user.PasswordHash = BCrypt.HashPassword(model.Password);

        // save user
        _context.Payment.Add(Payment);
        _context.SaveChanges();

        if(model.isSaveWallet == 'Y')
        {
            if (_context.Wallet.Any(x => (x.cardNo != model.CardNo)))
            {
              var Wallet = _mapper.Map<Wallet>(model);

               _context.Wallet.Add(Wallet);
            }
        }

        return Payment.paymentID;
    }


    // helper methods
    private Payment getPayment(int id)
    {
        //var Customer = _context.Customer.FirstOrDefault( c => c.custID == id);
        var Payment = _context.Payment.Find(id);
        if (Payment == null) throw new KeyNotFoundException("Order not found");
        return Payment;
    }
}