using RPG.Entities.Abstract;
using RPG.Entities.Character;

namespace RPG.Entities.Equipment
{
    public class CharacterEquipmentEntity: EntityIntBase
    {
        public int EquipmentSlotId { get; set; }
        public EquipmentSlotEntity EquipmentSlot { get; set; }
        
        public int CharacterId { get; set; }
        public CharacterEntity Character { get; set; }

        public int EquipmentId { get; set; }
        public EquipmentEntity Equipment { get; set; }

    }
}