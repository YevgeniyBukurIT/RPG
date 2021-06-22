using System.ComponentModel.DataAnnotations;

namespace RPG.Entities.Abstract
{
    public class EntityIntBase: IEntity<int>
    {
        [Key]
        public int Id { get; set; }
    }
}