using RPG.Entities.Abstract;

namespace RPG.Entities.Character
{
    public class WeaponSlotEntity: EntityIntBase
    {
        public WeaponSlot Slot { get; set; }
    }

    public enum WeaponSlot
    {
        RightHand,
        LeftHand,
        TwoHands
    }
}