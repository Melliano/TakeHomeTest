using TakeHomeTest.Api.Models;
using TakeHomeTest.Api.Models.User;

namespace TakeHomeTest.ViewModels;

public class SearchUserVM
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public GenderEnum Gender { get; set; }

    private SearchUserVM(int id, string firstName, string surname, string email, GenderEnum gender)
    {
        Id = id;
        FirstName = firstName;
        Surname = surname;
        Email = email;
        Gender = gender;
    }

    public static IEnumerable<SearchUserVM> GetSearchUsersVMs(IEnumerable<User> users) =>
        users.Select(u => new SearchUserVM(u.Id, u.FirstName, u.Surname, u.Email, u.Gender)).ToList();
}