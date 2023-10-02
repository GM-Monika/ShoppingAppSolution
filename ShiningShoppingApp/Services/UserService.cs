using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;
using System.Security.Cryptography;
using System.Text;

namespace ShiningShoppingApp.Services
{
    public class UserService : IUserService
    {
         private readonly IUserRepo<string, Login> _loginRepository;
      //  private readonly ITokenService _tokenSevice;
        public UserService(IUserRepo<string,Login> repository)// ITokenService tokenService)
        {
            _loginRepository = repository;
          //  _tokenSevice = tokenService;
        }
        public Users Login(Login userDTO)
        {
           // var user = _loginRepository.Get(userDTO.Email);
            if (!(userDTO.Email=="" && userDTO.Password == ""))
            {
                HMACSHA512 hMACSHA512 = new HMACSHA512();

                string password = hMACSHA512.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password)).ToString();


          var Userdetails =_loginRepository.FindByEmailAndPassword(userDTO.Email,password);
                if (Userdetails != null)
                {
            return Userdetails.Users;

                }
                else
                {
                    return null;
                }

            }
              
            return null;
        }

        public Login Register(Users userDTO)
        {

            HMACSHA512 hMACSHA512 = new HMACSHA512();
            Login userLogin = new Login();
            userLogin = userDTO.Login;
            userLogin.Password = hMACSHA512.ComputeHash(Encoding.UTF8.GetBytes(userLogin.Password)).ToString();
            userDTO.Login = null;
            userLogin.Users = userDTO;
             Login registerUser=_loginRepository.Add(userLogin);
          /*   var regiteredUser = new UserDTO
            {
                UserName = user.UserName,
                Token = _tokenSevice.GenerateToken(user.UserName, user.Role)
            }; */
            return registerUser;
        }

     
    }
}
