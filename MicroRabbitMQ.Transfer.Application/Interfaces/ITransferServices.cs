using MicroRabbitMQ.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMQ.Transfer.Application.Interfaces
{
    public interface ITransferServices
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
