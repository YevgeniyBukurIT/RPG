using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.DTO;
using RPG.DTO.Character;
using RPG.Entities.Equipment.EquipmentMapper;
using RPG.Entities.Player.PlayerMapper;
using RPG.Entities.Weapon.WeaponMapper;

namespace RPG.Entities.Character.CharacterMapper
{
    public static class CharacterMapper
    {
        public static CharacterEntity ModelToEntity(this CharacterModel character)
        {
            return new CharacterEntity
            {
                Id = character.Id,
                Name = character.Name,
                SexId = character.Sex.Id,
                CharacterTypeId = character.CharacterType.Id,
                PlayerId = character.Player.Id,

                

            };
        }

        public static CharacterModel EntityToModel(this CharacterEntity character)
        {
            return new CharacterModel
            {
                Id = character.Id,
                Name = character.Name,
                Sex = character.Sex.EntityToModel(),
                CharacterType = character.CharacterType.EntityToModel(),
                Player = character.Player.EntityToModel(),
                Equipment = character.Equipment.Select(e => e.EntityToModel()).ToList(),
                Weapons = character.Weapons.Select(e => e.EntityToModel()).ToList(),
                
                
            };
        }
    }
}
