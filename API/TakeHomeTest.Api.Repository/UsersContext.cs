using TakeHomeTest.Api.Models;
using TakeHomeTest.Api.Models.User;

namespace TakeHomeTest.Api.Repository;

public static class UsersContext
{
    public static IEnumerable<User> GetDummyData()
    {
        var users = new List<User>
        {
            new()
            {
                Id = 1,
                FirstName = "Antony",
                Surname = "Fitt",
                Email = "afitt0@a8.net",
                Gender = GenderEnum.Male
            },
            new()
            {
                Id = 2,
                FirstName = "Katey",
                Surname = "Gaines",
                Email = "kgaines1@bbb.org",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 3,
                FirstName = "Ardelle",
                Surname = "Soames",
                Email = "asoames2@google.it",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 4,
                FirstName = "Kalila",
                Surname = "Tennant",
                Email = "ktennant3@phpbb.com",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 5,
                FirstName = "Veda",
                Surname = "Emma",
                Email = "vemma4@nature.com",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 6,
                FirstName = "Pauli",
                Surname = "Isacke",
                Email = "pisacke5@is.gd",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 7,
                FirstName = "Belita",
                Surname = "Ruoff",
                Email = "bruoff6@wiley.com",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 8,
                FirstName = "James",
                Surname = "Kubu",
                Email = "hkubu7@craigslist.org",
                Gender = GenderEnum.Male
            },
            new()
            {
                Id = 9,
                FirstName = "Jasen",
                Surname = "Jiroudek",
                Email = "jjiroudek8@google.it",
                Gender = GenderEnum.Polygender
            },
            new()
            {
                Id = 10,
                FirstName = "Gusty",
                Surname = "Tuxill",
                Email = "gtuxill9@illinois.edu",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 11,
                FirstName = "James",
                Surname = "Pfeffer",
                Email = "bpfeffera@amazon.com",
                Gender = GenderEnum.Male
            },
            new()
            {
                Id = 12,
                FirstName = "Mignonne",
                Surname = "Whitewood",
                Email = "mwhitewoodb@godaddy.com",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 13,
                FirstName = "Moselle",
                Surname = "Gaize",
                Email = "mgaizec@tumblr.com",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 14,
                FirstName = "Chalmers",
                Surname = "Longfut",
                Email = "clongfujam@wp.com",
                Gender = GenderEnum.Male
            },
            new()
            {
                Id = 15,
                FirstName = "Linnell",
                Surname = "Jumont",
                Email = "ljumonte@storify.com",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 16,
                FirstName = "Viole",
                Surname = "Eaglen",
                Email = "veaglenf@nytimes.com",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 17,
                FirstName = "Sileas",
                Surname = "Tarr",
                Email = "starrg@telegraph.co.uk",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 18,
                FirstName = "Katey",
                Surname = "Soltan",
                Email = "ksoltanh@simplemachines.org",
                Gender = GenderEnum.Female
            },
            new()
            {
                Id = 19,
                FirstName = "Gar",
                Surname = "Motion",
                Email = "gmotioni@shop-pro.jp",
                Gender = GenderEnum.Male
            },
            new()
            {
                Id = 20,
                FirstName = "Kameko",
                Surname = "Vanes",
                Email = "kvanesj@discuz.ne",
                Gender = GenderEnum.Female
            }
        };

        return users;
    }
}