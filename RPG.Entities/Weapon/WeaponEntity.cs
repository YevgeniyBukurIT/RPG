using RPG.Entities.Abstract;

namespace RPG.Entities.Weapon
{
    public class WeaponEntity: EntityIntBase
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Price { get; set; }
        
        public string WeaponTypeId { get; set; }
        public WeaponTypeEntity WeaponType { get; set; }
    }
}