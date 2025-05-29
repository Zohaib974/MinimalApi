using MinimalApi.Dto.Business;
using MinimalApi.IServices;

namespace MinimalApi.Implementation
{
    public class BusinessService : IBusinessService
    {
        public BusinessModel CreateBusiness(BusinessModel dto)
        {
            return dto;
        }
        public BusinessModel GetBusiness(int id)
        {
            return new BusinessModel()
            {
                Id = id,
                BusinessId = 344636463,
                Name = "Clothing",
                Description = "We offer best quallity clothes."
            };
        }
        public List<BusinessModel> GetBusinessList()
        {
            return new List<BusinessModel>(){
                new BusinessModel()
                {
                    BusinessId = 344636463,
                    Name = "Clothing",
                    Description = "We offer best quallity clothes."
                },
                new BusinessModel()
                {
                    BusinessId = 984433300,
                    Name = "Dairy",
                    Description = "We offer fresh and quallity dairy products."
                }
            };
        }
        public BusinessModel UpdateBusiness(BusinessModel dto, int id)
        {
            dto.Id = id;
            return dto;
        }
    }
}
