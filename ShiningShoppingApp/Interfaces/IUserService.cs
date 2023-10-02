using ShiningShoppingApp.Models;
namespace ShiningShoppingApp.Interfaces
    
{
    public interface IUserService
    {
        public Users Login(Login users);
        public Login Register(Users users);
    }
}
