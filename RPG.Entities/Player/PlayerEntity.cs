using System.Collections.Generic;
using RPG.Entities.Abstract;
using RPG.Entities.Character;

namespace RPG.Entities.Player
{
    public class PlayerEntity: EntityIntBase
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public IEnumerable<CharacterEntity> Characters { get; set; }
    }
}