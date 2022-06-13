using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface ICheckoutRepository
    {
        List<Checkout> getAllCheckout();
        void AddCheckout(Checkout newcheckout);
        bool UpdateCheckout(Checkout newcheckout);
        bool DeleteCheckout(int checkoutId);
        Checkout getDetailBook(int checkoutId);
    }
}
