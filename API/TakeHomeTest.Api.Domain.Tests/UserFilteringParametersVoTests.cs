using FluentAssertions;
using Xunit;

namespace TakeHomeTest.Api.Domain.Tests;

public class UserFilteringParametersVoTests
{
    [Fact]
    public void Creation_Will_Fail_If_SearchString_Less_Than_1()
    {
        var result = UserFilteringParametersVo.Create("");

        result.IsFailure.Should().BeTrue();
        result.Error.Should().Be(UserFilteringParametersVo.Reasons.SearchMinLength);
    }
}