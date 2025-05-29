using MinimalApi.Configurations.Endpoints;

namespace MinimalApi.Configurations
{
    public static class ConfigureEndpoints
    {
        public static void ConfigureBusinessEndpoints( this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapGetBusinessList();
            routeBuilder.MapGetBusiness();
            routeBuilder.MapCreateBusiness();
            routeBuilder.MapUpdateBusiness();
        }
        public static void ConfigureAccountEndpoints(this IEndpointRouteBuilder routeBuilder)
        {
            // Account endpoints come here
        }
    }
}
