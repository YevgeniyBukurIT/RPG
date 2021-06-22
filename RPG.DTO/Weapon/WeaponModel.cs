using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Weapon
{
    public class WeaponModel : ModelIntBase
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Price { get; set; }
        public WeaponTypeModel WeaponType { get; set; }
    }
}
