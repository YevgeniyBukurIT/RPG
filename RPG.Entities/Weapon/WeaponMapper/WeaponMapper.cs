using RPG.DTO.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Weapon.WeaponMapper
{
    public static class WeaponMapper
    {
        public static WeaponEntity ModelToEntity(this WeaponModel weapon)
        {
            return new WeaponEntity
            {
                Id = weapon.Id,
                Name = weapon.Name,
                Damage = weapon.Damage,
                Price = weapon.Price,
                WeaponTypeId = weapon.WeaponType.Id,

            };
        }

        public static WeaponModel EntityToModel(this WeaponEntity weapon)
        {
            return new WeaponModel
            {
                Id = weapon.Id,
                Name = weapon.Name,
                Damage = weapon.Damage,
                Price = weapon.Price,
                WeaponType = weapon.WeaponType.EntityToModel()
                
            };
        }
    }
}
