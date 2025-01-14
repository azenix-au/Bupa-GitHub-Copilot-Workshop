using AutoMapper;
using DishesApi.Entities;
using DishesApi.Models;

namespace DishesApi.Profiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<Ingredient, IngredientDto>()
              .ForMember(
                  d => d.DishId,
                  o => o.MapFrom(s => s.Dishes.First().Id));
        }
    }
}
