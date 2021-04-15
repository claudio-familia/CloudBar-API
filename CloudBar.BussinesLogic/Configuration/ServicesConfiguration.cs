using System;
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
using CloudBar.Domain.Warehouse;
using CloudBar.BusinessLogic.Services.Warehouse;
using CloudBar.BusinessLogic.Services.Sale;
using CloudBar.Domain.Sale;

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
            services.AddScoped<IBaseService<Employee>, EmployeeService>();
            #endregion

            #region Warehouse

            services.AddScoped<IBaseService<Category>, CategoryService>();
            services.AddScoped<IBaseService<Item>, ItemService>();

            #endregion 
            
            #region Sales

            services.AddScoped<ISaleOrderService, SaleOrderService>();
            services.AddScoped<IBaseService<Client>, ClientService>();
            services.AddScoped<IBaseService<Invoice>, InvoiceService>();

            #endregion

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICryptographyService, CryptographyService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
        }
    }
}
