using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentLibrary.Core.Dtos;
using StudentLibrary.Core.Services;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Controllers
{
    [Route("api/[controller][Action]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            _operationService = operationService;
        }
        public async Task<IActionResult> GetAll()
        {
            var operations = await _operationService.GetAllAsync();
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var operation = await _operationService.GetByIdAsync(id);
            return Ok(operation);
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(OperationUpdateDto operationUpdateDto)
        {
            await _operationService.UpdateAsync(operationUpdateDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _operationService.DeleteAsync(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OperationAddDto operationAddDto)
        {
            await _operationService.AddAsync(operationAddDto);
            return Created(string.Empty, operationAddDto);
        }

        public async Task<IActionResult> Count()
        {
            int count = await _operationService.CountAsync();
            return Ok(count);
        }

    }
}
