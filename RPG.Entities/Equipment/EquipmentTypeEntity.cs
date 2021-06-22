using RPG.Entities.Abstract;
using RPG.Entities.Character;

namespace RPG.Entities.Equipment
{
    public class EquipmentTypeEntity: EntityStringBase
    {
        public string CharacterTypeId { get; set; }
        public CharacterTypeEntity CharacterType { get; set; }

        public int EquipmentSlotId { get; set; }
        public EquipmentSlotEntity EquipmentSlot { get; set; }
    }
}