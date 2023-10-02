using ShiningShoppingApp.Context;
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ShiningShoppingApp.Repository
{
    public class UserRepo : IUserRepo<string, Login>
    {

        private readonly UserContext _context;
        public UserRepo(UserContext context)
        {
            _context = context;
        }

        public Login Add(Login item)
        {
            _context.Login.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Login Delete(string key)
        {
            throw new NotImplementedException();
        }

        public Login Get(string key)
        {
            throw new NotImplementedException();
        }

        public List<Login> GetAll()
        {
            throw new NotImplementedException();
        }

        public Login FindByEmailAndPassword(string email, string password) { 


            var user = _context.Login.FirstOrDefault(u => u.Email == email && u.Password == password);
            var UserDetails = _context.Users.FirstOrDefault(u => u.Id == user.UserId);
            user.Users = UserDetails;
            return user;
        }

        public Login Update(Login item)
        {
            throw new NotImplementedException();
        }
    }
}
