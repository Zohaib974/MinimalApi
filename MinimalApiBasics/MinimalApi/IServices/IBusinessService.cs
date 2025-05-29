using MinimalApi.Dto.Business;

namespace MinimalApi.IServices
{
    public interface IBusinessService
    {
        List<BusinessModel> GetBusinessList();
        BusinessModel GetBusiness(int businessId);
        BusinessModel CreateBusiness(BusinessModel dto);
        BusinessModel UpdateBusiness(BusinessModel dto,int businessId);
    }
}
