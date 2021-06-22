namespace RPG.Entities.Abstract
{
    public interface IModel<TKey> 
    {
        public TKey Id { get; set; }
    }
}