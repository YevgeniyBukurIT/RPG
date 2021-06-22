using RPG.DTO.Equipment;
using RPG.Entities.Character.CharacterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Equipment.EquipmentMapper
{
    public static class CharacterEquipmentMapper
    {
        public static CharacterEquipmentEntity ModelToEntity(this CharacterEquipmentModel characterEquipment)
        {
            return new CharacterEquipmentEntity
            {
                Id = characterEquipment.Id,
                EquipmentSlotId = characterEquipment.EquipmentSlot.Id,
                CharacterId = characterEquipment.Character.Id,
                EquipmentId = characterEquipment.Equipment.Id,
                
                

            };
        }

        public static CharacterEquipmentModel EntityToModel(this CharacterEquipmentEntity characterEquipment)
        {
            return new CharacterEquipmentModel
            {
                Id = characterEquipment.Id,
                EquipmentSlot = characterEquipment.EquipmentSlot.EntityToModel(),
                Character = characterEquipment.Character.EntityToModel(),
                Equipment = characterEquipment.Equipment.EntityToModel(),
                
                

            };
        }
    }
}
