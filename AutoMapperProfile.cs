
namespace backend
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Users, GetUserDto>();
            CreateMap<AddUserDto, Users>();
        }
    }
}