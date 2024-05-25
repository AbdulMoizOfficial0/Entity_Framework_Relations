using Entity_Framework_Relations.Data;
using Entity_Framework_Relations.DTOs;
using Entity_Framework_Relations.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Relations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TlouController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public TlouController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateCharacter(CharacterCreateDto request)
        {
            var newCharacter = new Character
            {
                Name = request.Name,
            };
            var backpack = new Backpack
            {
                Description = request.Backpack.Description,
                Character = newCharacter
            };
            newCharacter.Backpack = backpack;
            _dataContext.Characters.Add(newCharacter);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Characters.Include(c => c.Backpack).ToListAsync());
        }
    }

}
