using GestaoConta.Domain.DataTransfers;

namespace GestaoConta.Domain.Contracts.UserCase
{
    public interface IGestaoContaUserCase
    {
        void CreateAccount(AccountDTO accountDTO);
        List<AccountDTO> GetAccounts();
    }
}