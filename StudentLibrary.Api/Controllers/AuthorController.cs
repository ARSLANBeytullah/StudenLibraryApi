﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentLibrary.Core.Dtos;
using StudentLibrary.Core.Services;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<IActionResult> GetAll()
        {
            var authors = await _authorService.GetAllAsync();
            return Ok(authors);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var author = await _authorService.GetByIdAsync(id);
            return Ok(author);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AuthorAddDto authorAddDto)
        {
            await _authorService.AddAsync(authorAddDto);
            return Created(string.Empty, authorAddDto);
        }
        [Route("api/author/count")]
        public async Task<IActionResult> Count()
        {
            int count = await _authorService.CountAsync();
            return Ok(count);

        }

        [HttpPost]
        public async Task<IActionResult> Update(AuthorUpdateDto authorUpdateDto)
        {
            await _authorService.UpdateAsync(authorUpdateDto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            await _authorService.DeleteAsync(id);
            return NoContent();
        }

    }

}