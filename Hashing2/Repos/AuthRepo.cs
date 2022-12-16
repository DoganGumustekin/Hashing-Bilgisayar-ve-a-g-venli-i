using Hashing2.DbContextWithEF;
using Hashing2.DTOs;
using Hashing2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Collections.Generic;
using Hashing2.Services;
using Microsoft.AspNetCore.Identity;

namespace Hashing2.Repos
{
    public class AuthRepo
    {
        private UserService _userService;
        private aa _aa;
        public AuthRepo(UserService userService, aa aa)
        {
            _userService = userService;
            _aa = aa;
        }

        public void Register(UserForRegisterDto userForRegisterDto, string password)
        {
            
            string passwordhash;
            HashingManager.stringDegistir(password, out passwordhash);
            var user = new User
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Email = userForRegisterDto.Email,
                Password = passwordhash
            };
            _userService.Add(user);
        }

        public void Login(UserForLoginDto userForLoginDto, string kontrol)
        {
            var userCheck = _aa.GetByMail(userForLoginDto.Email);
            
            HashingManager.VerifyPassword(userForLoginDto.Password, userCheck.Password);
        }
    }
}
