using GestaoConta.Domain.Contracts.Infrastructure;
using GestaoConta.Domain.Contracts.UserCase;
using GestaoConta.Domain.DataTransfers;
using GestaoConta.Domain.Mappers;

namespace GestaoConta.UserCase
{
    
    public class GestaoContaUserCase : IGestaoContaUserCase
    {
        private readonly IGestaoContaDbContext gestaoContaDbContext;

        public GestaoContaUserCase(IGestaoContaDbContext _gestaoContaDbContext)
        {
            this.gestaoContaDbContext = _gestaoContaDbContext;
        }

        public void CreateAccount(AccountDTO accountDTO)
        {
            var accountExist = this.gestaoContaDbContext.GetAccountByAccountAndAgency(accountDTO.NumberAgency, accountDTO.NumberAccount, accountDTO.NumberDigit);

            if (accountExist != null)
            {
                throw new Exception("Conta já existe!");
            }

            var accountEntity = MapperAccountDTOToAccountEntity.Map(accountDTO);
            this.gestaoContaDbContext.SaveAccount(accountEntity);
        }

        public List<AccountDTO> GetAccounts()
        {
            var accounts = this.gestaoContaDbContext.GetAccounts();
            var accountsDTO = MapperAccountEntityToAccountDTO.Map(accounts);

            return accountsDTO;
        }
    }
}