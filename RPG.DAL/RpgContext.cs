using Microsoft.EntityFrameworkCore;
using RPG.Entities.Character;
using RPG.Entities.Equipment;
using RPG.Entities.Player;
using RPG.Entities.Weapon;

namespace RPG.DAL
{
    public class RpgContext : DbContext
    {
        public DbSet<CharacterEntity> Characters { get; set; }
        public DbSet<CharacterTypeEntity> CharacterTypes { get; set; }
        public DbSet<EquipmentSlotEntity> EquipmentSlots { get; set; }
        public DbSet<SexEntity> Sexes { get; set; }
        public DbSet<WeaponSlotEntity> WeaponSlots { get; set; }
        
        public DbSet<CharacterEquipmentEntity> CharacterEquipment { get; set; }
        public DbSet<EquipmentEntity> Equipment { get; set; }
        public DbSet<EquipmentTypeEntity> EquipmentTypes { get; set; }
        
        public DbSet<PlayerEntity> Players { get; set; }

        public DbSet<CharacterWeaponEntity> CharacterWeapons { get; set; }
        public DbSet<WeaponEntity> Weapons { get; set; }
        public DbSet<WeaponTypeEntity> WeaponTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RpgDb;Trusted_Connection=True;");
        }
    }
}