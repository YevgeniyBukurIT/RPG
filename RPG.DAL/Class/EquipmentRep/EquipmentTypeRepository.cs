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
    public class EquipmentTypeRepository : GenericRepository<string, EquipmentTypeEntity>, IEquipmentTypeRepository
    {
        public EquipmentTypeRepository(RpgContext context) : base(context) { }
    }
}
