using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace relationships.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _context;

        public CharacterController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Characters>>> Get(int UserId)
        {
            var characters = await _context.Characters
                .Where(c => c.UserId == UserId)
                .Include(c => c.Weapon)
                .Include(c => c.Skills)
                .ToListAsync();
            return characters;
        }

        [HttpPost]
        public async Task<ActionResult<List<Characters>>> Create(CreateCharacterDto request)
        {
            var user = await _context.Users.FindAsync(request.UserId);

            if (user == null)
            {
                return NotFound();
            }
            var newCharacter = new Characters
            {
                Name = request.Name,
                RpgClass = request.RpgClass,
                User = user
            };
            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync();
            return await Get(newCharacter.UserId);
        }

        [HttpPost("weapon")]
        public async Task<ActionResult<Characters>> AddWeapon(AddWeaponDto request)
        {
            var character = await _context.Characters.FindAsync(request.CharacterId);

            if (character == null)
            {
                return NotFound();
            }
            var newWeapon = new Weapons
            {
                Name = request.Name,
                Damage = request.Damage,
                Character = character
            };
            _context.Weapons.Add(newWeapon);
            await _context.SaveChangesAsync();
            return character;
        }

        [HttpPost("skill")]
        public async Task<ActionResult<Characters>> AddCharacterSkill(AddCharacterSkillDto request)
        {
            var character = await _context.Characters
                .Where(c => c.Id == request.CharacterId)
                .Include(c => c.Skills)
                .FirstOrDefaultAsync();

            if (character == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills.FindAsync(request.SkillId);

            if (skill == null)
            {
                return NotFound();
            }

            character.Skills.Add(skill);
            await _context.SaveChangesAsync();
            return character;
        }
    }
}