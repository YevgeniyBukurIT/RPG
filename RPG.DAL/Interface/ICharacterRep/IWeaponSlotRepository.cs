using RPG.DAL.Abstract;
using RPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Interface.CharacterRep
{
    public interface IWeaponSlotRepository : IRepository<int, WeaponSlotEntity>
    {
    }
}
