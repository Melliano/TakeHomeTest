using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using TakeHomeTest.Api.Models.User;

namespace TakeHomeTest.Api.Repository;

public interface IUserRepository
{
    Task<Result<List<User>>> GetUserBySearchString(string searchString);
}

public class UserRepository : IUserRepository
{
    private readonly ILogger<IUserRepository> _logger;

    public UserRepository(ILogger<IUserRepository> logger)
    {
        _logger = logger;
    }

    // Would be async in normal EF context...
    public async Task<Result<List<User>>> GetUserBySearchString(string searchString)
    {
        // Essentially a fake EF context
        // Usually would put a using statement here if using the context 
        // or if file reading. For now just a static class will do
        var dummyData = UsersContext.GetDummyData();

        var usersList = new List<User>();

        var users = /* await */dummyData.Where(
            x => (x.FirstName + " " + x.Surname).Contains(searchString, StringComparison.InvariantCultureIgnoreCase)
                 || x.Email.Contains(searchString, StringComparison.InvariantCultureIgnoreCase));

        usersList.AddRange(users);

        return Result.Success(usersList);
    }
}