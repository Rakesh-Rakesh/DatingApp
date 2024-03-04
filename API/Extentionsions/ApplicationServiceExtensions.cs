using API.Data;
using Microsoft.EntityFrameworkCore;
using API.Interfaces;
using API.Services;

namespace API;

public static class ApplicationServiceExtensions
{
public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
                        IConfiguration config )
{
    services.AddDbContext<DataContext>(opt => 
{
    opt.UseSqlite(config.GetConnectionString("DefaultConnection"));

});

services.AddScoped<ITokenService , TokenService>();
services.AddCors();

return services;
    
} 



}
