using RPG.DAL.Abstract;
using RPG.DAL.Interface.CharacterRep;
using RPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Class.CharacterRep
{
    public class EquipmentSlotRepository : GenericRepository<int, EquipmentSlotEntity>, IEquipmentSlotRepository
    {
        public EquipmentSlotRepository(RpgContext context) : base(context)
        {

        } 
    }
}
