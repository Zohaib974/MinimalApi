using MinimalApi.Dto.Account;
using MinimalApi.IServices;

namespace MinimalApi.Implementation
{
    public class AccountService : IAccountService
    {
        public AccountModel CreateAccount(AccountModel dto)
        {
            return dto;
        }
        public AccountModel GetAccount(int id)
        {
            return new AccountModel()
            {
                Id = id,
                AccountHolder = "Jon Doe",
                AccuntNumber = 34556,
                Description  = "Personal Account"
            };
        }
        public List<AccountModel> GetAccountList()
        {
            return new List<AccountModel>() {  
                new AccountModel()
                {
                    AccountHolder = "Jon Doe",
                    AccuntNumber = 34556,
                    Description  = "Personal Account"
                },
                new AccountModel()
                {
                    AccountHolder = "General Electronics",
                    AccuntNumber = 56444,
                    Description  = "Corporate Account"
                }
            };
        }
        public AccountModel UpdateAccount(AccountModel dto, int id)
        {
            dto.Id = id;
            return dto;
        }
    }
}
