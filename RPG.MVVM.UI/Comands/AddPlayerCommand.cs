using RPG.DTO.Player;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace RPG.MVVM.UI.Comands
{
    public class AddPlayerCommand : ICommand
    {
        private PlayerModel player;
        public AddPlayerCommand(PlayerModel player)
        {
            this.player = player;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            player.Name = "123";
        }
    }
}
