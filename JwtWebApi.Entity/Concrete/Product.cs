using JwtWebApi.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JwtWebApi.Entity.Concrete
{
    public class Product : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
