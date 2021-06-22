using RPG.DTO.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities.Character.CharacterMapper
{
    public static class SexMapper
    {
        public static SexEntity ModelToEntity(this SexModel sex)
        {
            return new SexEntity
            {
                Id = sex.Id
            };
        }

        public static SexModel EntityToModel(this SexEntity sex)
        {
            return new SexModel
            {
                Id = sex.Id
            };
        }
    }
}
