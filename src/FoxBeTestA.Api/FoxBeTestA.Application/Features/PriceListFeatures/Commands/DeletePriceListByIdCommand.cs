using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.Application.Processors;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.PriceListFeatures.Commands
{
    public class DeletePriceListByIdCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public class DeletePriceListByIdCommandHandler : IRequestHandler<DeletePriceListByIdCommand, bool>
        {
            private readonly IPriceListProcessor _PriceListProcessor;

            public DeletePriceListByIdCommandHandler(IPriceListProcessor PriceListProcessor)
            {
                _PriceListProcessor = PriceListProcessor;
            }
            public async Task<bool> Handle(DeletePriceListByIdCommand command, CancellationToken cancellationToken)
            {
                return await _PriceListProcessor.ExecuteDelete(command.Id);
            }
        }
    }
}
