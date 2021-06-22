using RPG.DAL.Abstract;
using RPG.Entities.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Interface.Weapon
{
    public interface IWeaponRepository : IRepository<int, WeaponEntity>
    {
    }
}
