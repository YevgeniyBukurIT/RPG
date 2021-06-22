using System.Collections.Generic;
using RPG.Entities.Abstract;
using RPG.Entities.Equipment;
using RPG.Entities.Player;
using RPG.Entities.Weapon;

namespace RPG.Entities.Character
{
    public class CharacterEntity: EntityIntBase
    {
        public string Name { get; set; }
        
        public string SexId { get; set; }
        public SexEntity Sex { get; set; }

        public string CharacterTypeId { get; set; }
        public CharacterTypeEntity CharacterType { get; set; }
        
        public int PlayerId { get; set; }
        public PlayerEntity Player { get; set; }
        
        public IEnumerable<CharacterEquipmentEntity> Equipment { get; set; }
        public IEnumerable<CharacterWeaponEntity> Weapons { get; set; }
    }
}