using MinimalApi.Implementation;
using MinimalApi.IServices;
using System.Runtime.CompilerServices;

namespace MinimalApi.Configurations
{
    public static class ConfigureServices
    {
        public static void AddBusinessServies (this IServiceCollection services)
        {
            services.AddTransient<IBusinessService, BusinessService>();
        }
        public static void AddAccountServies(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
        }
    }
}
