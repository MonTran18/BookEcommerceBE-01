using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface ICartRepository
    {
        void AddCart(Cart newcart);
        bool UpdateCart(Cart newcart);
        bool DeleteCart(int cartId);
        List<Cart> getAllCart();
        Cart getDetailCart(int cartId);
    }
}
