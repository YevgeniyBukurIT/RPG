using RPG.DTO.Character;
using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Equipment
{
    public class EquipmentTypeModel : ModelStringBase
    {        
        public CharacterTypeModel CharacterType { get; set; }

        public EquipmentSlotModel EquipmentSlot { get; set; }
    }
}
