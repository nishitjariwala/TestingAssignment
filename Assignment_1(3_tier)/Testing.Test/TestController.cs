using Passengers.BAL.Interface;
using Passengers.DAL.Repository;
using Moq;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment_1.Controllers;
using Passengers.Models;
using Xunit;
using System.Web.Mvc;
using System.Web.Http.Results;
using System.Web.Http;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Passengers.Test
{
    public class TestController
    {
        private readonly Mock<ICustomerDetail> mockData = new Mock<ICustomerDetail>();

        private readonly CustomerController _customerController;
        public TestController()
        {
            _customerController = new CustomerController(mockData.Object);

        }

		//Successful test in get customer list
        [Fact]
        public void Done_GetCustomerList()
        {
            var result = mockData.Setup(m => m.GetCustomerList()).Returns(GetCustomer());
            var response = _customerController.Get();
            Assert.Equal(7, response.Count);
        }
		
		//Fail case in get Customer List
        [Fact]
        public void Null_GetCustomerList()
        {
            var result = mockData.Setup(m => m.GetCustomerList()).Equals(null);
            var response = _customerController.Get();
            Assert.Null(response);
        }
		[Fact]
        public void NotDone_GetCustomerList()
        {
            var result = mockData.Setup(m => m.GetCustomerList()).Returns(GetCustomer());
            var response = _customerController.Get();
            Assert.notEqual(3, response.Count);
        }
		//Successful test in add new customer
        [Fact]
        public void Done_AddNewCustomer()
        {
            var newUser = new Customer();
            newUser.Id = 1;
            newUser.f_name = "abc";
            newUser.l_name = "xyz";
            newUser.phone_no = "1234567890";
            var result = mockData.Setup(m => m.AddNewCustomer(newUser)).Returns(AddCustomer());
            var response = _customerController.Post(newUser);
            Assert.NotNull(response);
        }
		
		//Fail case in Add new Customer
        [Fact]
        public void NotDone_AddNewCustomer()
        {
            var newUser = new Customer();
            newUser.Id = 1;
            newUser.f_name = null;
            newUser.l_name = null;
            newUser.phone_no = null;
            var result = mockData.Setup(m => m.AddNewCustomer(newUser)).Equals(null);
            var response = _customerController.Post(newUser);
            Assert.Null(response);
        }
		//Successful test in update customer
        [Fact]
        public void Done_UpdateCustomer()
        {
            var model = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("UpdateData/customer.json"));
            var resultObj = mockData.Setup(m => m.UpdateCustomer(model, model.Id)).Returns(model);
            var response = _customerController.Put(model, model.Id);
            Assert.Equal(model, response);
        }
		//Fail case in Update Customer
        [Fact]
        public void NotDone_UpdateCustomer()
        {
            var model = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("UpdateData/customer.json"));
            var resultObj = mockData.Setup(m => m.UpdateCustomer(model, model.Id)).Equals(null);
            var response = _customerController.Put(model, model.Id);
            Assert.NotEqual(model, response);
        }
		//Successful test in Delete customer
        [Fact]
        public void Done_DeleteCustomer()
        {
            var customer = new Customer();
            customer.Id = 1;
            var resultObj = mockData.Setup(m => m.DeleteCustomer(customer.Id)).Returns(true);
            var response = _customerController.Delete(customer.Id);
            Assert.True(response);
        }
		
		//Fail case in Delete Customer
        [Fact]
        public void NotDone_DeleteCustomer()
        {
            var customer = new Customer();
            customer.Id = 1;
            var resultObj = mockData.Setup(m => m.DeleteCustomer(customer.Id)).Returns(false);
            var response = _customerController.Delete(customer.Id);
            Assert.False(response);
        }
		//For get customer List
        private static IList<Customer> GetCustomer()
        {
            IList<Customer> customer = new List<Customer>()
            {
                new Customer() { Id = 1, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
                new Customer() { Id = 2, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
                new Customer() { Id = 3, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
                new Customer() { Id = 4, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
				new Customer() { Id = 5, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
                new Customer() { Id = 6, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
                new Customer() { Id = 7, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
            };
            return customer;
        }
		// for 
        private static Customer AddCustomer()
        {
            var newUser = new Customer();
            newUser.Id = 8;
            newUser.f_name = "Nishit";
            newUser.l_name = "Jariwala";
            newUser.phone_no = "8140557205";
            return newUser;
        }



    }
}
