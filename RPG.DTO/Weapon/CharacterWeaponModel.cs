using RPG.DTO.Character;
using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Weapon
{
    public class CharacterWeaponModel : ModelIntBase
    {
        public WeaponSlotModel WeaponSlot { get; set; }

        public CharacterModel Character { get; set; }

        public WeaponModel Weapon { get; set; }
    }
}
