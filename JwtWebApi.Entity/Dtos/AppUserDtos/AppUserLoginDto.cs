using JwtWebApi.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JwtWebApi.Entity.Dtos.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
