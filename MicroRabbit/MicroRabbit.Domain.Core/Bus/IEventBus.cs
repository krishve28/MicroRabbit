﻿using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;//bcos event is a reserved keyword in C# we prefix with @ symbol

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
