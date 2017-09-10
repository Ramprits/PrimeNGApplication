using System;
using System.Collections.Generic;

namespace Primeng.data
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
