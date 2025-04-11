﻿using MediatR;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Features.Mediator.Handlers
{
    public class RemoveProductCommandHandler(IRepository<Product> repository,IUnitOfWork unitOfWork) : IRequestHandler<RemoveProductCommand, bool>
    {
        public async Task<bool> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            await repository.DeleteAsync(request.id);
            return await unitOfWork.SaveChangesAsync();
        }
    }
}
