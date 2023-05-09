using System.Buffers;
using CSharpFunctionalExtensions;

namespace TakeHomeTest.Api.Domain;

public class UserFilteringParametersVo : ValueObject
{
    public string SearchString { get;}

    protected UserFilteringParametersVo(string searchString)
    {
        SearchString = searchString;
    }

    public static Result<UserFilteringParametersVo> Create(string? searchString)
    {
        var stringLengthResult = string.IsNullOrEmpty(searchString)
            ? Result.Failure(Reasons.SearchMinLength)
            : Result.Success();
        
        // You can add more validation here and do a Result.Combine() in future...
        if (stringLengthResult.IsFailure)
            return Result.Failure<UserFilteringParametersVo>(stringLengthResult.Error);

        var userFilteringParamsCandidate = new UserFilteringParametersVo(searchString.Trim());

        return userFilteringParamsCandidate;
    }

    public static class Reasons
    {
        public static readonly string SearchMinLength = $"Search string must be 1 or more characters";
    }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return SearchString;
    }
}