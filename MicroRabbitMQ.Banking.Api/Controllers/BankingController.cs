using System.Collections.Generic;
using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Application.Models;
using MicroRabbitMQ.Banking.Domain.Commands;
using MicroRabbitMQ.Banking.Domain.Models;
using MicroRabbitMQ.Domain.Core.Bus;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {

        private readonly IAccountService _accountService;


        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;

        }

        // Get api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody]AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);

            return Ok(accountTransfer);     
        }

    }
}
