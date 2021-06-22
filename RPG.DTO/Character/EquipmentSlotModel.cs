using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Character
{
    public class EquipmentSlotModel : ModelIntBase
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
