using AutoMapper;
using DishesApi.Entities;
using DishesApi.Models;

namespace DishesApi.Profiles
{
    public class DishProfile : Profile
    {
        public DishProfile()
        {
            CreateMap<Dish, DishDto>();
        }
    }
}
