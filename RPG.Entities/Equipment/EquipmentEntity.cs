using RPG.Entities.Abstract;

namespace RPG.Entities.Equipment
{
    public class EquipmentEntity: EntityIntBase
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Price { get; set; }
        
        public string EquipmentTypeId { get; set; }
        public EquipmentTypeEntity EquipmentType { get; set; }
    }
}