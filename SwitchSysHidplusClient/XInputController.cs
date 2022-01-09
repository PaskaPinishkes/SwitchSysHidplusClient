using SharpDX.XInput;
using System;
using SwitchSysHidplusClient.Enums;

namespace SwitchSysHidplusClient
{
    // Some code taken from: https://stackoverflow.com/questions/39109609/how-to-use-xbox-one-controller-in-c-sharp-application
    public class XInputController : IDisposable
    {
        private Controller controller;
        private Gamepad gamepad;
        private bool leftTrigger, rightTrigger;
        private Multimedia.Timer timer = new Multimedia.Timer();

        public int layoutStyle { get; set; }

        public bool Connected { 
            get { return controller.IsConnected; }
        }
        public int LeftStickX { get; private set; } = 0;
        public int LeftStickY { get; private set; } = 0;
        public int RightStickX { get; private set; } = 0;
        public int RightStickY { get; private set; } = 0;
        public UInt64 Buttons { get; private set; } = 0;

        public XInputController(UserIndex userIndex = UserIndex.One)
        {
            controller = new Controller(userIndex);

            // Timer setup
            timer.Period = 2;
            timer.Resolution = 1;
            timer.Tick += Update;
            timer.Start();
        }

        public void Dispose()
        {
            timer.Stop();
            timer.Tick -= Update;
            timer.Dispose();
        }

        ~XInputController()
            => Dispose();

        private void Update(object source, EventArgs e)
        {
            if (!Connected)
                return;

            gamepad = controller.GetState().Gamepad;
            
            LeftStickX = gamepad.LeftThumbX;
            LeftStickY = gamepad.LeftThumbY;
            RightStickX = gamepad.RightThumbX;
            RightStickY = gamepad.RightThumbY;

            // I don't have an Xbox Controller to check if this trigger values are okay :b
            if (gamepad.LeftTrigger > 10)
                leftTrigger = true;
            else
                leftTrigger = false;

            if (gamepad.RightTrigger > 10)
                rightTrigger = true;
            else
                rightTrigger = false;

            ConvertToSwitchButtons();
        }

        private void ConvertToSwitchButtons()
        {
            // Prepare for A TON of if statements until I find a better solution
            Buttons = 0;

            // "Main" buttons:
            // A/B and X/Y are inverted, in the normal switch layout

            if(layoutStyle == 0)
            {
                if ((gamepad.Buttons & GamepadButtonFlags.A) == GamepadButtonFlags.A)
                    Buttons |= (ulong)SwitchButtons.B;

                if ((gamepad.Buttons & GamepadButtonFlags.B) == GamepadButtonFlags.B)
                    Buttons |= (ulong)SwitchButtons.A;

                if ((gamepad.Buttons & GamepadButtonFlags.X) == GamepadButtonFlags.X)
                    Buttons |= (ulong)SwitchButtons.Y;

                if ((gamepad.Buttons & GamepadButtonFlags.Y) == GamepadButtonFlags.Y)
                    Buttons |= (ulong)SwitchButtons.X;
            }
            
            //In the xbox layout, buttons are not inverted
            else if(layoutStyle == 1)
            {
                if ((gamepad.Buttons & GamepadButtonFlags.A) == GamepadButtonFlags.A)
                    Buttons |= (ulong)SwitchButtons.A;

                if ((gamepad.Buttons & GamepadButtonFlags.B) == GamepadButtonFlags.B)
                    Buttons |= (ulong)SwitchButtons.B;

                if ((gamepad.Buttons & GamepadButtonFlags.X) == GamepadButtonFlags.X)
                    Buttons |= (ulong)SwitchButtons.X;

                if ((gamepad.Buttons & GamepadButtonFlags.Y) == GamepadButtonFlags.Y)
                    Buttons |= (ulong)SwitchButtons.Y;
            }

            
            // Sticks (not the positions, whether they are clicked or not)
            if ((gamepad.Buttons & GamepadButtonFlags.LeftThumb) == GamepadButtonFlags.LeftThumb)
                Buttons |= (ulong)SwitchButtons.StickL;

            if ((gamepad.Buttons & GamepadButtonFlags.RightThumb) == GamepadButtonFlags.RightThumb)
                Buttons |= (ulong)SwitchButtons.StickR;


            // Shoulder and Trigger buttons
            if ((gamepad.Buttons & GamepadButtonFlags.LeftShoulder) == GamepadButtonFlags.LeftShoulder)
                Buttons |= (ulong)SwitchButtons.L;

            if ((gamepad.Buttons & GamepadButtonFlags.RightShoulder) == GamepadButtonFlags.RightShoulder)
                Buttons |= (ulong)SwitchButtons.R;

            if (leftTrigger)
                Buttons |= (ulong)SwitchButtons.ZL;

            if (rightTrigger)
                Buttons |= (ulong)SwitchButtons.ZR;


            // + and -
            if ((gamepad.Buttons & GamepadButtonFlags.Start) == GamepadButtonFlags.Start)
                Buttons |= (ulong)SwitchButtons.Plus;

            if ((gamepad.Buttons & GamepadButtonFlags.Back) == GamepadButtonFlags.Back)
                Buttons |= (ulong)SwitchButtons.Minus;


            // DPad
            if ((gamepad.Buttons & GamepadButtonFlags.DPadUp) == GamepadButtonFlags.DPadUp)
                Buttons |= (ulong)SwitchButtons.DPadUp;

            if ((gamepad.Buttons & GamepadButtonFlags.DPadDown) == GamepadButtonFlags.DPadDown)
                Buttons |= (ulong)SwitchButtons.DPadDown;

            if ((gamepad.Buttons & GamepadButtonFlags.DPadLeft) == GamepadButtonFlags.DPadLeft)
                Buttons |= (ulong)SwitchButtons.DPadLeft;

            if ((gamepad.Buttons & GamepadButtonFlags.DPadRight) == GamepadButtonFlags.DPadRight)
                Buttons |= (ulong)SwitchButtons.DPadRight;
        }
    }
}

/* Copyright (c) 2010-2015 SharpDX - Alexandre Mutel
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */