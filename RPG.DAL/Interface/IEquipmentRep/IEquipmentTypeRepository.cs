using RPG.DAL.Abstract;
using RPG.Entities.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Interface.Equipment
{
    public interface IEquipmentTypeRepository : IRepository<string, EquipmentTypeEntity>
    {
    }
}
