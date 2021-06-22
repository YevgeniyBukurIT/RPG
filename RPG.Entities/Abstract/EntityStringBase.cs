using System.ComponentModel.DataAnnotations;

namespace RPG.Entities.Abstract
{
    public class EntityStringBase: IEntity<string>
    {
        [Key]
        public string Id { get; set; }
    }
}