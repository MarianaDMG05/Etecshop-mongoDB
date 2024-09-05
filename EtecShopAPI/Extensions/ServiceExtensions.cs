
namespace EtecShopAPI.Extensions
{
    public class ServiceExtensions
    {
        public static void ConfigureCors( this IserviceCollection services)
        {
            services.AddCors(options => 
            {
                options.AddPolicy("CorsPolicy",
                builder => builder
                .AllowAnyOring()
                .AllowAnyMethody()
                .AllowAnyHeader()
                );
            });
        }
        public static void ConfigureMongoDBSettings( this IServiceCollection services, IConfiguration config)
        {

        }
    }
}