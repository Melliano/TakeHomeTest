using Microsoft.AspNetCore.Mvc;
using TakeHomeTest.Api.Domain;
using TakeHomeTest.Services;
using TakeHomeTest.ViewModels;

namespace TakeHomeTest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet(Name = "SearchUsers")]
    [ProducesResponseType(200, Type = typeof(List<SearchUserVM>))]
    public async Task<IActionResult> GetUsers([FromQuery] string? searchString)
    {
        var searchStringResult = UserFilteringParametersVo.Create(searchString);
        if (searchStringResult.IsFailure)
        {
            _logger.LogError($"Failure to ingest search string. Error: {searchStringResult.Error}");
            return new BadRequestObjectResult(searchStringResult.Error);
        }

        var userSearchResult = await _userService.GetUsersBySearchString(searchStringResult.Value.SearchString);
        if (userSearchResult.IsFailure)
        {
            _logger.LogError($"Failed to get users by search string. Error: {userSearchResult.Error}");
            return new ObjectResult(userSearchResult.Error) { StatusCode = StatusCodes.Status500InternalServerError };
        }
        var userSearchVMs = SearchUserVM.GetSearchUsersVMs(userSearchResult.Value);

        return new OkObjectResult(userSearchVMs);
    }
}