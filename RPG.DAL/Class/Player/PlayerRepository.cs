using System.Linq;
using RPG.DAL.Abstract;
using RPG.Entities.Player;

namespace RPG.DAL
{
    public class PlayerRepository: GenericRepository<int, PlayerEntity>, IPlayerRepository
    {
        public PlayerRepository(RpgContext context) : base(context)
        {
        }

        public PlayerEntity GetByName(string name)
        {
            return Set.FirstOrDefault(p => p.Name == name);
        }
    }
}