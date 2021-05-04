using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyRecipes.Api.Contracts.Responses;
using TastyRecipes.Api.Domain;

namespace TastyRecipes.Api.Mapping
{
    public class DomainToResponse : Profile
    {
        public DomainToResponse()
        {
            CreateMap<Category, CategoryResponse>();
        }
    }
}
