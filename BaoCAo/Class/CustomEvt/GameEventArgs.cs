using BaoCAo.Class.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCAo.Class.CustomEvt
{
    public class GameEventArgs : EventArgs
    {
        public Game Game { get; private set; }

        public GameEventArgs(Game game)
        {
            Game = game;
        }
    }

}
