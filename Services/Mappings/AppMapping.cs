using App.Core.Entities;
using App.Services.DTOs.Product;
using AutoMapper;

namespace App.Services.Mappings
{
    public class AppMapping : Profile
    {
        public AppMapping()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
