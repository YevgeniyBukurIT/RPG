
using RPG.DTO.Character;
using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Equipment
{
    public class CharacterEquipmentModel : ModelIntBase
    {
        
        public EquipmentSlotModel EquipmentSlot { get; set; }

        
        public CharacterModel Character { get; set; }

        
        public EquipmentModel Equipment { get; set; }

    }
}
