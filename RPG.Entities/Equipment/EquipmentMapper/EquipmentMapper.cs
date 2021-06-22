using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.DTO;
using RPG.DTO.Equipment;

namespace RPG.Entities.Equipment.EquipmentMapper
{
    public static class EquipmentMapper
    {
        public static EquipmentEntity ModelToEntity(this EquipmentModel equipment)
        {
            return new EquipmentEntity
            {
                Id = equipment.Id,
                Name = equipment.Name,
                Armor = equipment.Armor,
                Price = equipment.Price,
                EquipmentTypeId = equipment.EquipmentType.Id

            };
        }

        public static EquipmentModel EntityToModel(this EquipmentEntity equipment)
        {
            return new EquipmentModel
            {
                Id = equipment.Id,
                Name = equipment.Name,
                Armor = equipment.Armor,
                Price = equipment.Price,
                EquipmentType = equipment.EquipmentType.EntityToModel(),
               
            };
        }
    }
}
