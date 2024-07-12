using GestaoConta.Domain.DataTransfers;
using GestaoConta.Domain.Entities;

namespace GestaoConta.Domain.Mappers
{
    public static class MapperAccountEntityToAccountDTO
    {
        public static AccountDTO Map(AccountEntity accountEntity)
        {
            return new AccountDTO
            {
                Id = accountEntity.Id,
                CodeBank = accountEntity.CodeBank,
                NumberAgency = accountEntity.NumberAgency,
                NumberAccount = accountEntity.NumberAccount,
                NumberDigit = accountEntity.NumberDigit,
                NameClient = accountEntity.NameClient,
                Document = accountEntity.Document
            };
        }

        public static List<AccountDTO> Map(List<AccountEntity> accountEntities)
        {
            var accountsDTO = new List<AccountDTO>();

            foreach (var accountEntity in accountEntities)
            {
                accountsDTO.Add(Map(accountEntity));
            }

            return accountsDTO;
        }
    }
}