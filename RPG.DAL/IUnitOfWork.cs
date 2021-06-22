using RPG.DAL.Abstract;
using RPG.DAL.Interface;
using RPG.DAL.Interface.CharacterRep;
using RPG.DAL.Interface.Equipment;
using RPG.DAL.Interface.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        RpgContext db { get; set; }
        ICharacterRepository characters { get; set; }
        ICharacterTypeRepository characterTypes { get; set; }
        IEquipmentSlotRepository equipmentSlots { get; set; }
        ISexRepository sexes { get; set; }
        IWeaponSlotRepository weaponSlots { get; set; }
        ICharacterEquipmentRepository characterEquipments { get; set; }
        IEquipmentRepository equipments { get; set; }
        IEquipmentTypeRepository equipmentTypes { get; set; }
        IPlayerRepository players { get; set; }
        ICharacterWeaponRepository characterWeapons { get; set; }
        IWeaponRepository weapons { get; set; }
        IWeaponTypeRepository weaponTypes { get; set; }
        void Save();
<<<<<<< HEAD

        void Dispose();
=======
>>>>>>> 9eae9dc (Project)
    }
}
