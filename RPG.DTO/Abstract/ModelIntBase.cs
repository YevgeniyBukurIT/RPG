using System.ComponentModel.DataAnnotations;

namespace RPG.Entities.Abstract
{
    public class ModelIntBase: IModel<int>
    {
        [Key]
        public int Id { get; set; }
    }
}