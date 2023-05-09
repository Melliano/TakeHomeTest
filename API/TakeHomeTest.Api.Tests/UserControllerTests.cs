using CSharpFunctionalExtensions;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using TakeHomeTest.Api.Domain;
using TakeHomeTest.Api.Models;
using TakeHomeTest.Api.Models.User;
using TakeHomeTest.Api.Repository;
using TakeHomeTest.Controllers;
using TakeHomeTest.Services;
using TakeHomeTest.ViewModels;
using Xunit;

namespace TakeHomeTest.Api.Tests;

public class UserControllerTests
{
    private readonly Mock<IUserService> _mockUserService;
    private readonly Mock<ILogger<UserController>> _mockLogger;
    private readonly UserController _sut;
    
    public UserControllerTests()
    {
        _mockUserService = new Mock<IUserService>();
        _mockLogger = new Mock<ILogger<UserController>>();
        _sut = new UserController(_mockLogger.Object, _mockUserService.Object);
    }

    [Fact]
    public async Task Given_GetUsers_Empty_String_Will_Return_400_Bad_Request()
    {
        var result = await _sut.GetUsers("");
        
        result.Should().BeOfType<BadRequestObjectResult>();
        var typedResult = result as BadRequestObjectResult;
        typedResult.Value.Should().Be(UserFilteringParametersVo.Reasons.SearchMinLength);
    }

    [Fact]
    public async Task Given_GetUsers_UserService_ThrowsError_Will_Return_500_With_Error()
    {
        _mockUserService.Setup(x => x.GetUsersBySearchString(It.IsAny<string>()))
            .ReturnsAsync(Result.Failure<List<User>>("Boom big error"));

        var result = await _sut.GetUsers("Callum");

        var typedResult = result as ObjectResult;

        typedResult.StatusCode.Should().Be(StatusCodes.Status500InternalServerError);
        typedResult.Value.Should().Be("Boom big error");
    }

    [Fact]
    public async Task Given_GetUsers_Succeeds_Returns_200_With_Payload()
    {
        var expectedResult = SearchUserVM.GetSearchUsersVMs(UsersContext.GetDummyData().Where(x => x is { FirstName: "Katey", Surname: "Soltan" }));
        _mockUserService.Setup(x => x.GetUsersBySearchString(It.IsAny<string>()))
            .ReturnsAsync(Result.Success(new List<User>
            {
                new()
                {
                    Id = 18,
                    FirstName = "Katey",
                    Surname = "Soltan",
                    Email = "ksoltanh@simplemachines.org",
                    Gender = GenderEnum.Female
                },
            }));
        
        var result = await _sut.GetUsers("katey soltan");
        
        result.Should().BeOfType<OkObjectResult>();
        GetVMFromActionResult_UserSearch_List<List<SearchUserVM>>(result).Should().BeEquivalentTo(expectedResult);
    }

    private T GetVMFromActionResult_UserSearch_List<T>(IActionResult result) where T : List<SearchUserVM>
    {
        var okResult = result as OkObjectResult;
        return (T)okResult.Value;
    }
}