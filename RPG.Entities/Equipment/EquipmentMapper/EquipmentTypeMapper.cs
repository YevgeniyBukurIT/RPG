using RPG.DTO.Equipment;
using RPG.Entities.Character.CharacterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Equipment.EquipmentMapper
{
    public static class EquipmentTypeMapper
    {
        public static EquipmentTypeEntity ModelToEntity(this EquipmentTypeModel equipmentType)
        {
            return new EquipmentTypeEntity
            {
                Id = equipmentType.Id,
                CharacterTypeId = equipmentType.CharacterType.Id,
                EquipmentSlotId = equipmentType.EquipmentSlot.Id
            };
        }

        public static EquipmentTypeModel EntityToModel(this EquipmentTypeEntity equipmentType)
        {
            return new EquipmentTypeModel
            {
                Id = equipmentType.Id,
                EquipmentSlot = equipmentType.EquipmentSlot.EntityToModel(),
                CharacterType = equipmentType.CharacterType.EntityToModel()
                
                
            };
        }
    }
}
