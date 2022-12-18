global using AutoMapper;
namespace Backend.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private static List<Users> users = new List<Users> {
                new Users{
                    Id=1,
                    Username="BXDMAN",
                    Password="BXDMAN"
                },
                new Users{
                    Id=2,
                    Username="User",
                    Password="User"
                }
        };

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }


        public async Task<ServiceResponse<List<GetUserDto>>> GetUsers()
        {
            var serviceResponse = new ServiceResponse<List<GetUserDto>>();
            serviceResponse.Data = users.Select(c => _mapper.Map<GetUserDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> GetUser(int id)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            var user = users.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetUserDto>(user);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> AddUser(AddUserDto user)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            var u = _mapper.Map<Users>(user);
            u.Id = users.Max(c => c.Id) + 1;
            users.Add(u);
            serviceResponse.Data = _mapper.Map<GetUserDto>(u);
            return serviceResponse;
        }
    }
}
