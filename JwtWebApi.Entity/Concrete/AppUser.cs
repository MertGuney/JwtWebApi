﻿using JwtWebApi.Entity.Interfaces;
using System.Collections.Generic;

namespace JwtWebApi.Entity.Concrete
{
    public class AppUser : ITable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<AppUserRole> AppUserRoles { get; set; }
    }
}
