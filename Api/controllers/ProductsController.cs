using Application.Commands;
using Application.DTOs;
using Application.Interfaces;
using Application.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IProductsQuery _productsQuery;
        public ProductsController(IMediator mediator, IProductsQuery productsQuery)
        {
            _mediator = mediator;
            _productsQuery = productsQuery;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _productsQuery.GetAllProducts());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var product = await _productsQuery.GetProductById(id);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand dto)
        {
            var commandResult = await _mediator.Send(dto);
            return commandResult != null ? Ok(commandResult) : (IActionResult)BadRequest();
        }


        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return result != Guid.Empty ? Ok(result) : (IActionResult)NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteProductCommand { Id = id };
            var result = await _mediator.Send(command);
            return result != Guid.Empty ? Ok(result) : (IActionResult)NotFound();

        }
    }
}
