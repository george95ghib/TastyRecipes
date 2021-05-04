using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyRecipes.Api.Contracts.Requests;
using TastyRecipes.Api.Domain;

namespace TastyRecipes.Api.Mapping
{
    public class RequestToDomain : Profile
    {
        public RequestToDomain()
        {
            CreateMap<CreateCategoryRequest, Category>();
        }
    }
}
