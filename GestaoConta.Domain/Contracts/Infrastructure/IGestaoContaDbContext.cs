using GestaoConta.Domain.Entities;

namespace GestaoConta.Domain.Contracts.Infrastructure
{
    public interface IGestaoContaDbContext
    {
        List<AccountEntity> GetAccounts();
        void SaveAccount(AccountEntity account);
        AccountEntity GetAccountByAccountAndAgency(int agency, int account, int digit);
    }
}