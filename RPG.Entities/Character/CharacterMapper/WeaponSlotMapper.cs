using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.DTO;
using RPG.DTO.Character;

namespace RPG.Entities.Character.CharacterMapper
{
    public static class WeaponSlotMapper
    {
        public static WeaponSlotEntity ModelToEntity(this WeaponSlotModel weaponSlot)
        {
            return new WeaponSlotEntity
            {
                Id = weaponSlot.Id,
                Slot = (WeaponSlot)weaponSlot.Slot
            };
        }

        public static WeaponSlotModel EntityToModel(this WeaponSlotEntity weaponSlot)
        {
            return new WeaponSlotModel
            {
                Id = weaponSlot.Id,
                Slot = (DTO.Character.WeaponSlot)weaponSlot.Slot

            };
        }
    }
}
