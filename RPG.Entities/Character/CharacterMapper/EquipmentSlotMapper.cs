using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.DTO;
using RPG.DTO.Character;

namespace RPG.Entities.Character.CharacterMapper
{
    public static class EquipmentSlotMapper
    {
        public static EquipmentSlotEntity ModelToEntity(this EquipmentSlotModel equipmentSlot)
        {
            return new EquipmentSlotEntity
            {
                Id = equipmentSlot.Id,
                Slot = (EquipmentSlot)equipmentSlot.Slot
            };
        }

        public static EquipmentSlotModel EntityToModel(this EquipmentSlotEntity equipmentSlot)
        {
            return new EquipmentSlotModel
            {
                Id = equipmentSlot.Id,
                Slot = (DTO.Character.EquipmentSlot)equipmentSlot.Slot
            };
        }
    }
}
