using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Character
{
    public class WeaponSlotModel : ModelIntBase
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

