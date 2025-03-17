using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            //throw new NotImplementedException();

            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From, 
                ToAccount = @event.To, 
                TransferAmount = @event.Amount
            });

            return Task.CompletedTask;

            //A lot of things can be done here like 1) doing calculation 2) calling another api 3) writing to a DB etc...
        }
    }
}
