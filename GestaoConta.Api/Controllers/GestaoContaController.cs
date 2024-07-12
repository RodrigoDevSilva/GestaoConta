using GestaoConta.Domain.Contracts.UserCase;
using GestaoConta.Domain.DataTransfers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoConta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GestaoContaController : ControllerBase
    {
        private readonly IGestaoContaUserCase gestaoContaUserCase;

        public GestaoContaController(IGestaoContaUserCase _gestaoContaUserCase)
        {
            this.gestaoContaUserCase = _gestaoContaUserCase;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(gestaoContaUserCase.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountDTO accountDTO)
        {
            try
            {
                gestaoContaUserCase.CreateAccount(accountDTO);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }   
    }
}
