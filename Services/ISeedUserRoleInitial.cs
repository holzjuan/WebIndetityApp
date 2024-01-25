namespace WebIdentityApp.Services
{
    public interface ISeedUserRoleInitial
    {
        Task SeedRolesAsync();
        Task SeedUserAsync();
    }
}
