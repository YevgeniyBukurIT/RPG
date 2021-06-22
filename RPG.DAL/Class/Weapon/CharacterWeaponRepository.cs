using RPG.DAL.Abstract;
using RPG.DAL.Interface.Weapon;
using RPG.Entities.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Class.Weapon
{
    public class CharacterWeaponRepository : GenericRepository<int, CharacterWeaponEntity>, ICharacterWeaponRepository
    {
        public CharacterWeaponRepository(RpgContext context) : base(context) { }
    }
}
