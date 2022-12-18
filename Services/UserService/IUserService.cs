namespace Backend.Services.UserService
{
    public interface IUserService
    {
        
        List<Users> GetUsers();
        Users GetUser(int id);
        Users AddUser(Users user);
    }
}
