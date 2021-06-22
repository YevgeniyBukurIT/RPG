using RPG.DTO.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Character.CharacterMapper
{
    public static class CharacterTypeMapper
    {
        public static CharacterTypeEntity ModelToEntity(this CharacterTypeModel characterType)
        {
            return new CharacterTypeEntity
            {
                Id = characterType.Id
            };
        }

        public static CharacterTypeModel EntityToModel(this CharacterTypeEntity characterType)
        {
            return new CharacterTypeModel
            {
                Id = characterType.Id
            };
        }
    }
}
