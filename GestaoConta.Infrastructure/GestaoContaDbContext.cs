using GestaoConta.Domain.Contracts.Infrastructure;
using GestaoConta.Domain.Entities;

namespace GestaoConta.Infrastructure
{
    public class GestaoContaDbContext : IGestaoContaDbContext
    {
        private List<AccountEntity> AccountsSaved { get; set; }

        public List<AccountEntity> GetAccounts()
        {
            AccountsSaved = AccountsSaved ?? new List<AccountEntity>();
            return AccountsSaved;
        }

        public void SaveAccount(AccountEntity account)
        {
            AccountsSaved = AccountsSaved ?? new List<AccountEntity>();
            AccountsSaved.Add(account);
        }

        public AccountEntity GetAccountByAccountAndAgency(int agency, int account, int digit)
        {
            AccountsSaved = AccountsSaved ?? new List<AccountEntity>();
            return AccountsSaved.FirstOrDefault(x => x.NumberAgency == agency && x.NumberAccount == account && x.NumberDigit == digit);
        }
    }
}