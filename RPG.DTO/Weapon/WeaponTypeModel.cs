using RPG.DTO.Character;
using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Weapon
{
    public class WeaponTypeModel : ModelStringBase
    {
        public CharacterTypeModel CharacterType { get; set; }

        public WeaponSlotModel WeaponSlot { get; set; }
    }
}
