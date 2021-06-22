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
    public class UnitOfWork : IUnitOfWork
    {
        public RpgContext db { get; set ; }
        public ICharacterRepository characters { get; set; }
        public ICharacterTypeRepository characterTypes { get; set; }
        public IEquipmentSlotRepository equipmentSlots { get; set; }
        public ISexRepository sexes { get; set; }
        public IWeaponSlotRepository weaponSlots { get; set; }
        public ICharacterEquipmentRepository characterEquipments { get; set; }
        public IEquipmentRepository equipments { get; set; }
        public IEquipmentTypeRepository equipmentTypes { get; set; }
        public IPlayerRepository players { get; set; }
        public ICharacterWeaponRepository characterWeapons { get; set; }
        public IWeaponRepository weapons { get; set; }
        public IWeaponTypeRepository weaponTypes { get; set; }

        public UnitOfWork(RpgContext db, ICharacterRepository characters, ICharacterTypeRepository characterTypes, IEquipmentSlotRepository equipmentSlots, ISexRepository sexes,
            IWeaponSlotRepository weaponSlots, ICharacterEquipmentRepository characterEquipments, IEquipmentRepository equipments, IEquipmentTypeRepository equipmentTypes, 
            IPlayerRepository players, ICharacterWeaponRepository characterWeapons, IWeaponRepository weapons, IWeaponTypeRepository weaponTypes)
            
        {
            this.db = db;
            this.characters = characters;
            this.characterTypes = characterTypes;
            this.equipmentSlots = equipmentSlots;
            this.sexes = sexes;
            this.weaponSlots = weaponSlots;
            this.characterEquipments = characterEquipments;
            this.equipments = equipments;
            this.equipmentTypes = equipmentTypes;
            this.players = players;
            this.characterWeapons = characterWeapons;
            this.weapons = weapons;
            this.weaponTypes = weaponTypes;

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
