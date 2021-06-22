namespace RPG.Entities.Abstract
{
    public interface IEntity<TKey> 
    {
        public TKey Id { get; set; }
    }
}