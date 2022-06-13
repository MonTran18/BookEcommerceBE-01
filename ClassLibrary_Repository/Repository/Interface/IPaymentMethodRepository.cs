using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface IPaymentMethodRepository
    {
        List<PaymentMethod> getAllPaymentMethod();
        void AddPaymentMethod(PaymentMethod newpaymethod);
        bool UpdatePaymentMethod(PaymentMethod newpaymethod);
        bool DeletePaymentMethod(int paymethodId);
        PaymentMethod getPaymentMethod(int paymethodId);
    }
}
