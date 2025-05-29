using MinimalApi.Dto.Account;

namespace MinimalApi.IServices
{
    public interface IAccountService
    {
        List<AccountModel> GetAccountList();
        AccountModel GetAccount(int id);
        AccountModel CreateAccount(AccountModel dto);
        AccountModel UpdateAccount(AccountModel dto, int id);
    }
}
