using CommunityToolkit.Services;
using System.Collections.Generic;

namespace CommunityToolkit.Models;

public class User
{
    public string? FullName { get; private set; } = string.Empty;

    public string? Id { get; private set; } = string.Empty;
    public IList<string> Permissions { get; private set; } = new List<string>();
    public User()
    {
    }

    public User(string id)
    {
        Id = id;
    }

    /// <summary>
    /// Sets the FullName of the User
    /// </summary>
    /// <param name="name">The name to set the FullName to</param>
    public void SetName(string name)
    {
        FullName = name;
    }

    /// <summary>
    /// Sets the Id of this User
    /// </summary>
    /// <param name="id">The Id of the User</param>
    public void SetId(string id)
    {
        Id = id;
    }

    /// <summary>
    /// Check to see if User has a certain permission.
    /// </summary>
    /// <param name="permission">The permission to look for</param>
    /// <returns>true if User has the permissoin, false if User does not</returns>
    public bool HasPermission(string permission)
    {
        return Permissions.Contains(permission);
    }

    #region Data fetchers
    public void GetFullName()
    {
        FullName = UserService.FetchName(Id);
    }

    public void GetPermissions()
    {
        Permissions = UserService.FetchPermissions(Id);
    }
    #endregion
}
