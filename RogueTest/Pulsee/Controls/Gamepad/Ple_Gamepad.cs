﻿using System;
using OpenTK.Input;
using Pulsee.Controls.Devices.Buttons;

namespace Pulsee.Controls.Gamepad
{
    class Ple_Gamepad : IInputDevice
    {
        private bool[] _buttons = new bool[Enum.GetValues(typeof(GamepadButton)).Length];
        private string _description;
        private int _numButtons;
        private IntPtr _devID;
        private bool _repeat;
        private GamepadEventArgs bArgs = new GamepadEventArgs();


        #region contructors

        internal Ple_Gamepad() { return; }

        #endregion

        public bool this[GamepadButton button]
        {
            get { return _buttons[(int)button]; }
            internal set
            {
                if (_buttons[(int)button] != value)
                {
                    _buttons[(int)button] = value;

                    if (value && ButtonDown != null)
                    {
                        bArgs.Button = button;
                        ButtonDown(this, bArgs);
                    }
                    else if (!value && ButtonUp != null)
                    {
                        bArgs.Button = button;
                        ButtonUp(this, bArgs);
                    }
                    else if (!value && ButtonPressed != null)
                    {
                        bArgs.Button = button;
                        ButtonPressed(this, bArgs);
                    }
                }
            }
        }

        public int NumberOfButtons
        {
            get { return _numButtons; }
            internal set { _numButtons = value; }
        }

        public IntPtr DeviceID
        {
            get { return _devID; }
            internal set { _devID = value; }
        }
        
        public event EventHandler<GamepadEventArgs> ButtonDown;
        public event EventHandler<GamepadEventArgs> ButtonUp;
        public event EventHandler<GamepadEventArgs> ButtonPressed;

        #region IInputDevice Members

        public string Description
        {
            get { return _description; }
            internal set { _description = value; }
        }

        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Hid; }
        }

        #endregion

        internal void ClearButtons()
        {
            for (int i = 0; i < _buttons.Length; i++)
                if (this[(GamepadButton)i])
                    this[(GamepadButton)i] = false;
            return;
        }

    }
}
