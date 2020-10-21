using JwtWebApi.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JwtWebApi.Entity.Dtos.ProductDtos
{
    public class ProductAddDto : IDto
    {
        public string Name { get; set; }
    }
}
