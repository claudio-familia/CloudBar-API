using System;
using System.Collections.Generic;
using System.Text;
using CloudBar.BusinessLogic.Services;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Security;
using Microsoft.Extensions.DependencyInjection;

namespace CloudBar.BusinessLogic.Configuration
{
    public static partial class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {            
            services.AddScoped<IBaseService<Role>, RoleService>();
        }
    }
}
