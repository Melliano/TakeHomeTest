namespace TakeHomeTest.Api.Models.User;

public class User
{
    public int Id { get; set; } // Should this be an int

    public string FirstName { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public GenderEnum Gender { get; set; }
}