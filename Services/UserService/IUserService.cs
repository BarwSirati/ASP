namespace Backend.Services.UserService
{
    public interface IUserService
    {

        Task<ServiceResponse<List<GetUserDto>>> GetUsers();
        Task<ServiceResponse<GetUserDto>> GetUser(int id);
        Task<ServiceResponse<GetUserDto>> AddUser(AddUserDto user);
    }
}
