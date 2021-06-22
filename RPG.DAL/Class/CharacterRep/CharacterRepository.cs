using Microsoft.EntityFrameworkCore;
using RPG.DAL.Abstract;
using RPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL
{
    public class CharacterRepository : GenericRepository<int, CharacterEntity>, ICharacterRepository
    {
        public CharacterRepository(RpgContext context) : base(context)
        {
        }
        
        public IList<CharacterEntity> GetAllInclude()
        {
            return Set.Include(s => s.CharacterType).Include(s => s.Weapons).ThenInclude(w => w.Weapon).
                ThenInclude(w => w.WeaponType).Include(s => s.Equipment).ThenInclude(e => e.Equipment).ThenInclude(e => e.EquipmentType).ToList();
            
        }

        public CharacterEntity GetInclude(int id)
        {
            return Set.Include(s => s.CharacterType).Include(s => s.Weapons).ThenInclude(w => w.Weapon).
                ThenInclude(w => w.WeaponType).Include(s => s.Equipment).ThenInclude(e => e.Equipment).ThenInclude(e => e.EquipmentType).FirstOrDefault(s => s.Id == id);
        }

        
    }
}
