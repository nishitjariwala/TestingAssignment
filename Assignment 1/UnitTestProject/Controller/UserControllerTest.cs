using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Testing_Assignment_1.Controllers;
using Testing_Assignment_1.Database;
using Testing_Assignment_1.Interface;
using Xunit;
using Moq;
using System.Web.Http.Results;

namespace UnitTestProject.Controller
{
    
    public class UserControllerTest
    {
        private readonly Mock<IPassengerManager> mockRepository = new Mock<IPassengerManager>();
        private readonly UserController _userController;

        public UserControllerTest()
        {
            _userController = new UserController(mockRepository.Object);
        }

        [Fact]
        
        public void ReturningPassenger()
        {
            //Arrange
            int id = 1;
            var setup = mockRepository.Setup(x => x.GetPassenger(id)).Returns(GetPassenger(id));
            var expected = GetPassenger(id);

            //Act
            var result = _userController.Get(id);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void DoesNotReturningPassenger()
        {
            //Arrange
            int id = 0;
            var setup = mockRepository.Setup(x => x.GetPassenger(id));
            var expected = GetPassenger(id);

            //Act
            var result = _userController.Get(id);

            //Assert
            Assert.Null(result);
        }

        

        [Fact]
        public void UpdatingPassanger()
        {
            //Arrange
            var passenger = new Passenger() { FirstName = "Kalpana", LastName = "Jariwala", Phone = 815678203 };
            var setup = mockRepository.Setup(x => x.UpdatePassenger(1, passenger)).Returns(1);

            //Act
            var result = _userController.Edit(1, passenger);

            //Assert
            Assert.Equal(HttpStatusCode.OK, ((StatusCodeResult)result).StatusCode);
        }

        [Fact]
        public void DoesNotUpdatingPassenger()
        {
            //Arrange
            var passenger = new Passenger();
            var setup = mockRepository.Setup(x => x.UpdatePassenger(1, passenger)).Returns(0);

            //Act
            var result = _userController.Edit(1, passenger);

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }

        

        [Fact]
        public void InsertingPassengerSuccessfully()
        {
            //Arrange
            var passenger = new Passenger() { FirstName = "Test", LastName = "Test", Phone =123456789};
            var setup = mockRepository.Setup(x => x.CreatePassenger(passenger)).Returns(1);

            //Act
            var result = _userController.Create(passenger);

            //Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void ErrorInInsertingPassenger()
        {
            //Arrange
            var passenger = new Passenger() { FirstName = "Test", LastName = "Test", Phone = 123456789 };
            var setup = mockRepository.Setup(x => x.CreatePassenger(passenger));

            //Act
            var result = _userController.Create(passenger);

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void DeletingPassengerSuccessfully()
        {
            //Arrange
            var setup = mockRepository.Setup(x => x.DeletePassenger(1)).Returns(1);

            //Act
            var result = _userController.Delete(1);

            //Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void ErrorInDeletingPassenger()
        {
            //Arrange
            var setup = mockRepository.Setup(x => x.DeletePassenger(-1)).Returns(0);

            //Act
            var result = _userController.Delete(-1);

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }

        

        private static Passenger GetPassenger(int id)
        {
            List<Passenger> passengers = new List<Passenger>()
            {
                new Passenger() {Id = 1, FirstName = "Nishit", LastName = "Jariwala", Phone = 986545789 },
                new Passenger() {Id = 2, FirstName = "Mahek", LastName = "Jariwala", Phone = 894532789 },
                new Passenger() {Id = 3, FirstName = "Ashok", LastName = "Jariwala", Phone = 81455720 },
            };

            return passengers.Where(u => u.Id == id).First();
        }
    }

}
