using AutoMapper;
using Beca.BookInfo.API.MappingProfiles;


namespace Beca.BookInfo.API
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            // Registrar los perfiles de AutoMapper
            services.AddAutoMapper(typeof(BookProfile));

            // Resto de la configuración de la aplicación
            // ...
        }

    }
}
