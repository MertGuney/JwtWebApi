using JwtWebApi.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JwtWebApi.Entity.Dtos.AppUserDtos
{
    public class AppUserAddDto : IDto
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
    }
}
