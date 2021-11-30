using AutoMapper;
using CinemaOnline.BLL.Services;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Repositories.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace CinemaOnline.Tests
{
    public class CinemaOnlineBLLTests
    {
        [Fact]
        public void GetAllUsersCount()
        {
            var mockTicketDbContext = new Mock<TicketDbContext>();
            var mockIUserRepository = new Mock<IUserRepository>();
            mockIUserRepository.Setup(r => r.GetAllUsers()).Returns(GetTestEmails());
            var mockIMapper = new Mock<IMapper>();
            var userService = new UserService(mockTicketDbContext.Object, mockIUserRepository.Object, mockIMapper.Object);

            var result = userService.GetAllUsers();

            Assert.Equal(GetTestEmails().Count, result.Count);
        }

        private List<string> GetTestEmails()
        {
            var emails = new List<string>()
            {
                "a@a",
                "b@b",
                "c@c"
            };
            return emails;
        }
    }
}
