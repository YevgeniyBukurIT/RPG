using RPG.DTO.Character;
using RPG.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RPG.DTO.Player
{
    public class PlayerModel : ModelIntBase, INotifyPropertyChanged
    {
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Gold { get; set; }

        public IEnumerable<CharacterModel> Characters { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;

    }
}
