using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ClassLibrary_RepositoryDLL.Entities;
using ClassLibrary_RepositoryDLL.Services;
using ClassLibrary_RepositoryDLL.Models;
using ClassLibrary_RepositoryDLL.Mappings;

namespace ClassLibrary_RepositoryDLL.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, ProductModel>().ForMember(destination => destination.Name, action => action.MapFrom(source => source.Bookname));

            CreateMap<Book, Author>().ForMember(destination => destination.Id, action => action.MapFrom(source => source.Id));
            //CreateMap<Book, Category>();
            //CreateMap<Book, Publisher>();
            //CreateMap<Book, Cart>();
            CreateMap<Book, CartItem>().ForMember(destination => destination.Book, action => action.MapFrom(source => source.Id));
            CreateMap<Account, RegisterModel>().ForMember(destination => destination.Fullname, action => action.MapFrom(source => source.Username));
            CreateMap<Account, LoginModel>().ForMember(destination => destination.Username, action => action.MapFrom(source => source.Password));
            //CreateMap<Account, Cart>();
            //CreateMap<Account, Role>();
            CreateMap<PaymentMethod, CheckoutModel>().ForMember(destination => destination.PaymentId, action => action.MapFrom(source => source.Id));
            CreateMap<Checkout, CheckoutModel>().ForMember(destination => destination.Username, action => action.MapFrom(source => source.Account));
            CreateMap<Checkout, PaymentMethod>().ForMember(destination => destination.Id, action => action.MapFrom(source => source.Id));
            //CreateMap<Checkout, ShippingFee>();
            CreateMap<CartItem, Checkout>().ForMember(destination => destination.Id, action => action.MapFrom(source => source.CartId));
        }
    }
}
