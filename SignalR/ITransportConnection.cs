﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR
{
    public interface ITransportConnection
    {
        IDisposable Receive(string messageId, Func<Exception, PersistentResponse, Task<bool>> callback);

        Task<PersistentResponse> ReceiveAsync(string messageId, CancellationToken cancel);

        Task Send(string signal, object value);
    }
}