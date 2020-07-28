using BAYSOFT.Core.Domain.Entities;
using BAYSOFT.Infrastructures.Exceptions;
using FluentValidation;
using MediatR;
using NetDevPack.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BAYSOFT.Core.Application
{
    public abstract class ApplicationRequestHandler<TEntity, TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : ApplicationRequest<TEntity, TResponse>
        where TResponse : ApplicationResponse<TEntity>
        where TEntity : DomainEntity
    {
        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
