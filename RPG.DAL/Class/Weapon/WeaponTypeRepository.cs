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
    public class WeaponTypeRepository : GenericRepository<string, WeaponTypeEntity>, IWeaponTypeRepository
    {
        public WeaponTypeRepository(RpgContext context) : base(context) { }
    }
}
