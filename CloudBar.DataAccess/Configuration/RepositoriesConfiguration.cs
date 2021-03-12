using CloudBar.DataAccess.Repositories;
using CloudBar.DataAccess.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CloudBar.DataAccess.Configuration
{
    public static partial class RepositoriesConfiguration
    {
        public static void AddRespositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CloudBarDBContext>(m =>
            {
                m.UseMySQL(configuration.GetConnectionString("MardomGo"));
            });

            services.AddScoped<IDataRepositoryFactory, DataRepositoryFactory>();
            services.AddTransient(typeof(IDataRepository<>), typeof(Repository<>));
        }
    }
}
