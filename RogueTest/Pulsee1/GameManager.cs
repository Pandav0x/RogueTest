﻿using Pulsee1.KernelContent.Startup;
using Pulsee1.Game.GameStates;
using Pulsee1.Utilities.Display;
using Pulsee1.Display;
using Pulsee1.Controls.Events;
using Pulsee1.Game.Generators;
using Pulsee1.Display.Graphics;

namespace Pulsee1
{
    class GameManager
    {
        public GameStatesManager gasm;
        public DisplayManager dim;
        public EventManager evm;
        public GraphicsManager grm;
        public GeneratorsManager gem;

        public GameManager()
        {
            xConsole.WriteLine("Initializing management...");

            this.dim = new DisplayManager(this);
            this.grm = new GraphicsManager(this);
            this.evm = new EventManager(this);
            this.gasm = new GameStatesManager(this);
            this.gem = new GeneratorsManager();

            return;
        }

        public void Run()
        {
            Opening.PrintLogoOnScreen(this);

            this.gasm.StartFirstState();

            this.dim.StartWindow();

            return;
        }  
    }
}
