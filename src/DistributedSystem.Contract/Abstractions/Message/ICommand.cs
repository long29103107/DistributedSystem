﻿using DistributedSystem.Contract.Abstractions.Shared;
using MassTransit;
using MassTransit.Topology;
using MediatR;

namespace DistributedSystem.Contract.Abstractions.Message;

[ExcludeFromTopology]
public interface ICommand : IRequest<Result>
{
}

[ExcludeFromTopology]
public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
