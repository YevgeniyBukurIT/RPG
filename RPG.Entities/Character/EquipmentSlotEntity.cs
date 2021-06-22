using RPG.Entities.Abstract;

namespace RPG.Entities.Character
{
    public class EquipmentSlotEntity: EntityIntBase
    {
        public EquipmentSlot Slot { get; set; }
    }

    public enum EquipmentSlot
    {
        Helmet,
        Body,
        Hands,
        Legs,
    }
}