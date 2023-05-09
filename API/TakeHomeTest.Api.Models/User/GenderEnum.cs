namespace TakeHomeTest.Api.Models;
using System.Runtime.Serialization;

public enum GenderEnum
{
    [EnumMember(Value = "female")]
    Female,
    [EnumMember(Value = "male")]
    Male,
    [EnumMember(Value = "polygender")]
    Polygender,
    [EnumMember(Value = "other")]
    Other,
}