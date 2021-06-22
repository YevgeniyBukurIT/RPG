using RPG.DAL.Abstract;
using RPG.DAL.Interface.Equipment;
using RPG.Entities.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Class.EquipmentRep
{
    public class CharacterEquipmentRepository : GenericRepository<int, CharacterEquipmentEntity>, ICharacterEquipmentRepository
    {
        public CharacterEquipmentRepository(RpgContext context) : base(context) { }
    }
}
