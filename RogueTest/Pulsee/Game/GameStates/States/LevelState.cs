﻿using System;
using System.Linq;
using Pulsee.Game.GameStates.BaseState;
using Pulsee.Utilities.Display;

namespace Pulsee.Game.GameStates.States
{
    class LevelState : State
    {
        private int _floorNumber = 1; //number of floors (pretty obvious eh ?)

        public LevelState(GameManager parent_) : base (parent_){ }

        protected override void Content(params dynamic[] args)
        {
            xConsole.WriteLine("LevelState Started");

            //this._map = Enumerable.Range(0, _floorNumber).Select(i => new Floor()).ToArray();
            for (int i = 0; i < _floorNumber; i++)
            {
                //this._map[i].generateFloor();
            }

            return;
        }
    }
}
