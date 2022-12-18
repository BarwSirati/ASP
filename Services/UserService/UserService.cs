namespace Backend.Services.UserService
{
    public class UserService : IUserService
    {
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

        public Users AddUser(Users user)
        {
            users.Add(user);
            return user;
        }

        public Users GetUser(int id)
        {
            var user = users.Find(x => x.Id == id);
            return user;
        }

        public List<Users> GetUsers()
        {
            return users;
        }
    }
}
