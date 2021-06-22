using RPG.DTO.Equipment;
using RPG.DTO.Weapon;
using System;
using System.Collections.Generic;
using System.Text;
using RPG.DTO.Player;
using RPG.Entities.Abstract;

namespace RPG.DTO.Character
{
    public class CharacterModel : ModelIntBase
    {
        public string Name { get; set; }

        public  SexModel Sex { get; set; }

        public CharacterTypeModel CharacterType { get; set; }

        public PlayerModel Player { get; set; }

        public IEnumerable<CharacterEquipmentModel> Equipment { get; set; }
        public IEnumerable<CharacterWeaponModel> Weapons { get; set; }
    }
}
