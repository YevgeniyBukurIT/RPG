using RPG.DAL.Abstract;
using RPG.DAL.Interface;
using RPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Class.CharacterRep
{
    public class CharacterTypeRepository : GenericRepository<string, CharacterTypeEntity>, ICharacterTypeRepository
    {
        public CharacterTypeRepository(RpgContext context) : base(context) {}
    }
}
