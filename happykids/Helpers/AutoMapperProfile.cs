namespace happykids.Helpers;

using AutoMapper;
using happykids.Entities;
using happykids.Models.Basket;
using happykids.Models.Customer;
using happykids.Models.Order;
using happykids.Models.Payment;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // CreateRequest -> User
        CreateMap<CreateReqPayment, Payment>();
        CreateMap<CreateReqPayment, Wallet>();
        CreateMap<CreateReqOrd, Orders>();
        CreateMap<CreateRequest, Basket>();

        CreateMap<CreateRequestCustomer, Customer>();

        // UpdateRequest -> User
       /* CreateMap<UpdateRequest, Basket>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    // ignore null role
                    if (x.DestinationMember.Name == "Role" && src.Role == null) return false;

                    return true;
                }
            ));*/
    }
}