﻿using System;
using System.Collections.Generic;
using System.Text;
using CloudBar.BusinessLogic.Services.Security;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Common.Services;
using CloudBar.Common.Services.Contracts;
using CloudBar.Domain.General;
using CloudBar.Domain.Security;
using Microsoft.Extensions.DependencyInjection;
using CloudBar.BusinessLogic.Services.General;

namespace CloudBar.BusinessLogic.Configuration
{
    public static partial class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {            
            services.AddScoped<IBaseService<Role>, RoleService>();
            services.AddScoped<IBaseService<User>, UserService>();

            #region General
            services.AddScoped<IBaseService<Place>, PlaceService>();
            services.AddScoped<IBaseService<Person>, PersonService>();
            services.AddScoped<IBaseService<Parameter>, ParameterService>();
            #endregion

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICryptographyService, CryptographyService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
        }
    }
}
