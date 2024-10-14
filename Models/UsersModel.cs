using Microsoft.AspNetCore.Identity;
using PhoneBase.Models;

public record UsersModel(ApplicationDbContext Context, UserManager<User> UserManager)
{
    public IReadOnlyCollection<UserModel> Users { get; set; } = new List<UserModel>();

    public void UpdateUsers()
    {
        var adminRoleId = Context.Roles
            .Where(u => u.Name == "Admin")
            .Select(role => role.Id)
            .First();

        var query =
            from user in Context.Users
            select new UserModel()
            {
                id = user.Id,
                UserName = user.UserName,
                IsAdmin = Context.UserRoles.Any(
                    userRole => userRole.RoleId == adminRoleId && userRole.UserId == user.Id)
            };
        Users = query.ToList();
    }

    public async Task DeleteUser(string id)
    {
        var deletedUser = UserManager.Users.FirstOrDefault(user => user.Id == id);
        await UserManager.DeleteAsync(deletedUser);
        await Context.SaveChangesAsync();
    }
}