using GestaoConta.Domain.DataTransfers;
using GestaoConta.Domain.Entities;

namespace GestaoConta.Domain.Mappers
{
    public static class MapperAccountDTOToAccountEntity
    {
        static public AccountEntity Map(AccountDTO accountDTO)
        {
            return new AccountEntity
            {
                Id = accountDTO.Id,
                CodeBank = accountDTO.CodeBank,
                NumberAgency = accountDTO.NumberAgency,
                NumberAccount = accountDTO.NumberAccount,
                NumberDigit = accountDTO.NumberDigit,
                NameClient = accountDTO.NameClient,
                Document = accountDTO.Document
            };
        }
    }
}