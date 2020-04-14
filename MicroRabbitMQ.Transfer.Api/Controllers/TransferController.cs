using System.Collections.Generic;
using MicroRabbitMQ.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferServices _transferServices;

        public TransferController(ITransferServices transferServices)
        {
            _transferServices = transferServices;
        }

        // Get api/transfer
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_transferServices.GetTransferLogs());
        }

    }
}
