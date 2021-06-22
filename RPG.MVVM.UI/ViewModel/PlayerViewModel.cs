using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RPG.DTO;
using RPG.DTO.Player;
using RPG.MVVM.UI.Comands;

namespace RPG.MVVM.UI.ViewModel
{
    public class PlayerViewModel : INotifyPropertyChanged
    {
        public AddPlayerCommand AddPlayer { get => addPlayer; }

        private AddPlayerCommand addPlayer;
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private PlayerModel player;

        public PlayerModel Player
        {
            get => player;
            set
            {
                player = value;
                OnPropertyChanged(nameof(Player));
            }
        }

        public PlayerViewModel()
        {
            Player = new PlayerModel()
            {
                Name = "Tom"
            };

            addPlayer = new AddPlayerCommand(Player);
        }
    }


}
