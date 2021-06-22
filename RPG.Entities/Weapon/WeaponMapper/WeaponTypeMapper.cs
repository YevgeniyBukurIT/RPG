using RPG.DTO.Weapon;
using RPG.Entities.Character.CharacterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Weapon.WeaponMapper
{
    public static class WeaponTypeMapper
    {
        public static WeaponTypeEntity ModelToEntity(this WeaponTypeModel weaponType)
        {
            return new WeaponTypeEntity
            {
                Id = weaponType.Id,
                CharacterTypeId = weaponType.CharacterType.Id,
                WeaponSlotId = weaponType.WeaponSlot.Id
            };
        }

        public static WeaponTypeModel EntityToModel(this WeaponTypeEntity weaponType)
        {
            return new WeaponTypeModel
            {
                Id = weaponType.Id,
                CharacterType = weaponType.CharacterType.EntityToModel(),
                WeaponSlot = weaponType.WeaponSlot.EntityToModel()
                
            };
        }
    }
}
