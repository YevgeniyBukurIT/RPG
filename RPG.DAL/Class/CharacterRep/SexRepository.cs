using RPG.DAL.Abstract;
using RPG.DAL.Interface.CharacterRep;
using RPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DAL.Class.CharacterRep
{
    public class SexRepository : GenericRepository<string, SexEntity>, ISexRepository
    {
        public SexRepository(RpgContext context) : base(context) { }
    }
}
