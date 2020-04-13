using MicroRabbitMQ.Banking.Application.Models;
using MicroRabbitMQ.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}
