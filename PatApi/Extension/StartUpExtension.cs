using PatApi.Data;
using PatApi.Data;
using PatApi.Data.UnitOfWork;
using PatApi.Data.UnitOfWork.Concrete;

namespace PatApi.WebApi.Extension
{
    public static class StartUpExtension
    {
        public static void AddServices(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork,UnitOfWork>();

            services.AddScoped<IGenericRepository<Staff>,GenericRepository<Staff>>();
        }

    }
}
