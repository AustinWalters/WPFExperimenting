using System.Collections.Generic;

namespace CommunityToolkit.Services;

//TODO: Get way to get mock data

/// <summary>
/// This class should be used to make changes to the backend for a particular user or for getting informationa about a user
/// </summary>
public static class UserService
{
    public static string FetchName(string? id)
    {
        return id + "NameGoesHere";
    }

    internal static IList<string> FetchPermissions(string? id)
    {
        return new List<string> { "1", "2", "3" };
    }
}
