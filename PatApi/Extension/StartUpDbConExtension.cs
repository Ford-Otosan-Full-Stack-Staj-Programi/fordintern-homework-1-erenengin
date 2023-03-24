using Microsoft.EntityFrameworkCore;
using PatApi.Data;
using System;
using System.Runtime.CompilerServices;

namespace PatApi.WebApi.Extension
{
    public static class StartupDbContextExtension
    {
        public static void AddDbContextDI(this IServiceCollection services, IConfiguration configuration)
        {
            
                var dbConfig = configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<AppDbContext>(options => options
                   .UseSqlServer(dbConfig)
                   );
            
            
        }


    }
}
