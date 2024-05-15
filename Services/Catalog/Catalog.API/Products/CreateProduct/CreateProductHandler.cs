using System;
using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
	public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) : ICommand<CreateProductResult>;
	public record CreateProductResult(Guid Id);

	internal class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    { 
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //create Product entity from command object
            //save to database
            //return CreateProductResult result
            Product product = new()
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };
            //save to database
            //return result
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}

