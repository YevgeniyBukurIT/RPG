using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.DTO.Equipment
{
    public class EquipmentModel : ModelIntBase
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Price { get; set; }

        public EquipmentTypeModel EquipmentType { get; set; }
    }
}
