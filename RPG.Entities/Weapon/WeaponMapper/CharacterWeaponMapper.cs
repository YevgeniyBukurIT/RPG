using RPG.DTO.Weapon;
using RPG.Entities.Character.CharacterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Weapon.WeaponMapper
{
    public static class CharacterWeaponMapper
    {
        public static CharacterWeaponEntity ModelToEntity(this CharacterWeaponModel characterWeapon)
        {
            return new CharacterWeaponEntity
            {
                Id = characterWeapon.Id,
                WeaponId = characterWeapon.Weapon.Id,
                CharacterId = characterWeapon.Character.Id,
                WeaponSlotId = characterWeapon.Weapon.Id,
                
            };
        }

        public static CharacterWeaponModel EntityToModel(this CharacterWeaponEntity characterWeapon)
        {
            return new CharacterWeaponModel
            {
                Id = characterWeapon.Id,
                WeaponSlot = characterWeapon.WeaponSlot.EntityToModel(),
                Character = characterWeapon.Character.EntityToModel(),
                Weapon = characterWeapon.Weapon.EntityToModel()
                
            };
        }
    }
}
