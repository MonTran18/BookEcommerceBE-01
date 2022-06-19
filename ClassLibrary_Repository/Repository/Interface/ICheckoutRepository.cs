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
        bool searchCheckout(Checkout keyword);
        List<Checkout> getAllCheckout();
        void addCheckout(Checkout newcheckout);
        bool updateCheckout(Checkout newcheckout);
        bool deleteCheckout(int checkoutId);
        Checkout getDetailBook(int checkoutId);
    }
}
