using RPG.Entities.Player;

namespace RPG.DAL.Abstract
{
    public interface IPlayerRepository: IRepository<int, PlayerEntity>
    {
        PlayerEntity GetByName(string name);
    }
}