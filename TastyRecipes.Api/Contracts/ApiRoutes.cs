using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyRecipes.Api.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public static class Categories
        {
            public const string GetAll = Root + "/categories";

            public const string Get = Root + "/categories/{categoryId}";

            public const string Create = Root + "/categories";

        }
    }
}
