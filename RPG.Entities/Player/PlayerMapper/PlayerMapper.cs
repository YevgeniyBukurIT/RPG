using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.DTO;
using RPG.DTO.Player;
using RPG.Entities.Character.CharacterMapper;

namespace RPG.Entities.Player.PlayerMapper
{
    public static class PlayerMapper
    {
        public static PlayerEntity ModelToEntity(this PlayerModel player) 
        {
            return new PlayerEntity
            {
                Id = player.Id,
                Name = player.Name,
                Gold = player.Gold,
                
            };

        }

        public static PlayerModel EntityToModel(this PlayerEntity player)
        {
            return new PlayerModel
            {
                Id = player.Id,
                Name = player.Name,
                Gold = player.Gold,
                Characters = player.Characters.Select(e => e.EntityToModel()).ToList()
                
                
            };
        }
    }
}
