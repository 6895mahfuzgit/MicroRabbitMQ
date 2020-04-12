using MicroRabbitMQ.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMQ.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
