using Microsoft.AspNetCore.Mvc;
using MinimalApi.Dto.Business;
using MinimalApi.IServices;
using Swashbuckle.AspNetCore.Annotations;

namespace MinimalApi.Configurations.Endpoints
{
    public static class BusinessEndpoints
    {
        static readonly string Name = "Business";
        static readonly string GetBusinessList = "/getBusinessList";
        static readonly string GetBusiness = "/getBusiness/{businessId}";
        static readonly string CreateBusiness = "/createBusiness";
        static readonly string UpdateBusiness = "/updateBusiness/{businessId}";
        public static IEndpointConventionBuilder MapGetBusinessList(this IEndpointRouteBuilder builder)
        {
            return builder.MapGet(GetBusinessList , () =>
            {
                using var scope = builder.ServiceProvider.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IBusinessService>();
                var list = service.GetBusinessList();
                return (list?.Any() ?? false) ? Results.Ok(list) : Results.NoContent();
            }).WithMetadata(
                new SwaggerOperationAttribute
                {
                    Summary = "List of Business",
                    Description = "Returns a list of business records."
                })
            .Produces<List<BusinessModel>>(StatusCodes.Status200OK)
            .Produces<string>(StatusCodes.Status204NoContent)
            .WithTags(Name);
        }
        public static IEndpointConventionBuilder MapGetBusiness(this IEndpointRouteBuilder builder)
        {
            return builder.MapGet(GetBusiness, ([FromRoute] int businessId) =>
            {
                using var scope = builder.ServiceProvider.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IBusinessService>();
                return service.GetBusiness(businessId);
            }).WithTags(Name);
        }
        public static IEndpointConventionBuilder MapCreateBusiness(this IEndpointRouteBuilder builder)
        {
            return builder.MapPost(CreateBusiness, ([FromBody] BusinessModel dto) =>
            {
                using var scope = builder.ServiceProvider.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IBusinessService>();
                return service.CreateBusiness(dto);
            }).WithTags(Name);
        }
        public static IEndpointConventionBuilder MapUpdateBusiness(this IEndpointRouteBuilder builder)
        {
            return builder.MapPut(UpdateBusiness, ([FromBody] BusinessModel dto, [FromRoute]int businessId) =>
            {
                using var scope = builder.ServiceProvider.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IBusinessService>();
                return service.UpdateBusiness( dto, businessId);
            }).WithTags(Name);
        }
    }
}
