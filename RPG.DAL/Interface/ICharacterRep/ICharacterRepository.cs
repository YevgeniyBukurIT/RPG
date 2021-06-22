using RPG.DAL.Abstract;
using RPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL
{
    public interface ICharacterRepository : IRepository<int, CharacterEntity>
    {
        public CharacterEntity GetInclude(int id);

        public IList<CharacterEntity> GetAllInclude();

    }
}
