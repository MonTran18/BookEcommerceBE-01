﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;
using ClassLibrary_RepositoryDLL.Repository.Interface;

namespace ClassLibrary_RepositoryDLL.Repository
{
    public class CheckoutRepository : ICheckoutRepository
    {
        private readonly BookEcommerceContext _context;
        public CheckoutRepository(BookEcommerceContext context)
        {
            _context = context;
        }

        public void AddCheckout(Checkout newcheckout)
        {
            try
            {
                _context.Checkouts.Add(newcheckout);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public bool DeleteCheckout(int checkoutId)
        {
            Checkout checkout = _context.Checkouts.Find(checkoutId);
            if (checkout != null)
            {
                try
                {
                    _context.Checkouts.Remove(checkout);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception exception)
                {
                    System.Diagnostics.Debug.WriteLine(exception.Message);
                }
            }
            return false;
        }

        public List<Checkout> getAllCheckout()
        {
            List<Checkout> checkouts = _context.Checkouts.ToList();
            return checkouts;
        }

        public Checkout getDetailBook(int checkoutId)
        {
            Checkout checkout = _context.Checkouts.Find(checkoutId);
            return checkout;
        }

        public bool UpdateCheckout(Checkout newcheckout)
        {
            Checkout checkout = _context.Checkouts.SingleOrDefault(checkout => checkout.Id == newcheckout.Id);
            if (checkout != null)
            {
                try
                {
                    checkout.AccountId = newcheckout.AccountId;
                    checkout.Username = newcheckout.Username;
                    checkout.CartId = newcheckout.CartId;
                    checkout.ShippingfeeId = newcheckout.ShippingfeeId;
                    checkout.PaymentId = newcheckout.PaymentId;
                    checkout.Total = newcheckout.Total;
                    checkout.Depositornumber = newcheckout.Depositornumber;
                    checkout.Receivenember = newcheckout.Receivenember;
                    checkout.Quantity = newcheckout.Quantity;
                    _context.Checkouts.Update(newcheckout);
                    _context.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
            return false;
        }
    }
}
