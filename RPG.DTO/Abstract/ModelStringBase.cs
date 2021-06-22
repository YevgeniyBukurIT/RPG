using System.ComponentModel.DataAnnotations;

namespace RPG.Entities.Abstract
{
    public class ModelStringBase: IModel<string>
    {
        [Key]
        public string Id { get; set; }
    }
}