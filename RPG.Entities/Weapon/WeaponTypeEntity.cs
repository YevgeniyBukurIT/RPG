using RPG.Entities.Abstract;
using RPG.Entities.Character;

namespace RPG.Entities.Weapon
{
    public class WeaponTypeEntity: EntityStringBase
    {
        public string CharacterTypeId { get; set; }
        public CharacterTypeEntity CharacterType { get; set; }

        public int WeaponSlotId { get; set; }
        public WeaponSlotEntity WeaponSlot { get; set; }
    }
}