﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace prueba.services
{
    public static class EntityServices
    {
        public static void AddEntityServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
           
        }
    }
}
