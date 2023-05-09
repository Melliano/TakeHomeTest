using CSharpFunctionalExtensions;
using TakeHomeTest.Api.Models.User;
using TakeHomeTest.Api.Repository;
using TakeHomeTest.ViewModels;

namespace TakeHomeTest.Services;

public interface IUserService
{
    Task<Result<List<User>>> GetUsersBySearchString(string searchString);
}

public class UserService : IUserService
{
    private readonly ILogger<IUserService> _logger;
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository, ILogger<IUserService> logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    public async Task<Result<List<User>>> GetUsersBySearchString(string searchString) =>
        await _userRepository.GetUserBySearchString(searchString);
}