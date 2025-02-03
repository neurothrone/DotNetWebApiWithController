using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiWithController.Persistence.EFCore.Data;
using WebApiWithController.Persistence.EFCore.Models;

namespace WebApiWithController.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly HeroDbContext _context;

        public HeroController(HeroDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var heroes = await _context.Heroes
                .AsNoTracking()
                .ToListAsync();
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var hero = await _context.Heroes
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return hero is null ? NotFound() : Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Hero hero)
        {
            await _context.Heroes.AddAsync(hero);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = hero.Id }, hero);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Hero hero)
        {
            var existingHero = await _context.Heroes.FirstOrDefaultAsync(x => x.Id == id);
            if (existingHero is null)
                return NotFound();

            existingHero.Name = hero.Name;
            existingHero.SuperHeroName = hero.SuperHeroName;
            existingHero.Team = hero.Team;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existingHero = await _context.Heroes.FirstOrDefaultAsync(x => x.Id == id);
            if (existingHero is null)
                return NotFound();

            _context.Heroes.Remove(existingHero);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}