﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ClassLibrary_RepositoryDLL.Entities
{
    public partial class Checkout
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        [ForeignKey("Account_Id")]
        public DateTime? CreateDate { get; set; }
        public string Status { get; set; }
        public int? ShippingfeeId { get; set; }
        public int Depositornumber { get; set; }
        public int? Receivernumber { get; set; }
        public int? PaymentId { get; set; }

        public virtual Account Account { get; set; }
        public virtual PaymentMethod Payment { get; set; }
        public virtual ShippingFee Shippingfee { get; set; }
    }
}