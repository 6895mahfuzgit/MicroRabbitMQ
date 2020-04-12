using MicroRabbitMQ.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
