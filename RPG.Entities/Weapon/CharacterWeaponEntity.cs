using RPG.Entities.Abstract;
using RPG.Entities.Character;

namespace RPG.Entities.Weapon
{
    public class CharacterWeaponEntity: EntityIntBase
    {
        public int WeaponSlotId { get; set; }
        public WeaponSlotEntity WeaponSlot { get; set; }
        
        public int CharacterId { get; set; }
        public CharacterEntity Character { get; set; }

        public int WeaponId { get; set; }
        public WeaponEntity Weapon { get; set; }
    }
}