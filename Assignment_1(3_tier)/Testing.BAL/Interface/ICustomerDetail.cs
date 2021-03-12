﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passengers.Models;

namespace Passengers.BAL.Interface
{
    public interface ICustomerDetail
    {
        IList<Customer> GetCustomerList();
        Customer AddNewCustomer(Customer model);
        Customer UpdateCustomer(Customer model, int id);
        bool DeleteCustomer(int id);
    }
}
