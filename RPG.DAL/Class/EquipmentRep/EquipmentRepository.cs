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
    public class EquipmentRepository : GenericRepository<int, EquipmentEntity>, IEquipmentRepository
    {
        public EquipmentRepository(RpgContext context) : base(context) { }
    }
}
