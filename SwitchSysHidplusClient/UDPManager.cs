using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SharpDX.XInput;
using SwitchSysHidplusClient.Enums;

namespace SwitchSysHidplusClient
{
    public static class UDPManager
    {
        public static InputMode Mode { get; set; } = InputMode.Normal;

        private static Socket connectionSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private static IPAddress switchIP = IPAddress.Parse("0.0.0.0");
        private static IPEndPoint ep = new IPEndPoint(switchIP, 8000);

        public static XInputController[] controllers = new XInputController[4] {
            new XInputController(UserIndex.One),
            new XInputController(UserIndex.Two),
            new XInputController(UserIndex.Three),
            new XInputController(UserIndex.Four)
        };

        private static Multimedia.Timer networkTimer = new Multimedia.Timer();

        public static void StartNetworkLoop()
        {
            networkTimer.Period = 3;
            networkTimer.Resolution = 1;
            networkTimer.Tick += SendControls;
            networkTimer.Start();
            Console.WriteLine("Started Network Loop");
        }

        public static void StopNetworkLoop()
        {
            networkTimer.Stop();
            networkTimer.Tick -= SendControls;
        }

        public static void ChangeIPAddress(string newIP)
        {
            switchIP = IPAddress.Parse(newIP);
            ep.Address = switchIP;
        }

        private static void SendControls(object source, EventArgs eventArgs)
        {
            try
            {
                // connectedControllers allows us to bind XInput controllers to different sys-hidplus controller slots.
                // The ControllerCount we send to sys-hidplus will always be 4 in order to disconnect controllers disconnected from the PC.
                // In a future date, I'll remove ControllerCount from the Switch side, but in order to mantain compatibility with other clients,
                // that won't happen for now.
                var data = new SysHidplusData();

                for (ushort i = 0; i < 4; i++)
                {
                    if (controllers[i].Connected)
                    {
                        SetPacketControllerState(i, controllers[i], ref data);
                    }
                }

                using SocketAsyncEventArgs socketArgs = new SocketAsyncEventArgs();

                socketArgs.SetBuffer(StructureToByteArray(data));
                socketArgs.RemoteEndPoint = ep;
                socketArgs.SocketFlags = SocketFlags.DontRoute; // I assume DontRoute reduces lag (??????????)

                connectionSocket.SendToAsync(socketArgs);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error sending inputs: {exception.Message}");
            }
        }

        private static void SetPacketControllerState(ushort controllerIndex, XInputController controller, ref SysHidplusData packet)
        {
            // In Anarchy mode, all players use only 1 controller
            if (Mode == InputMode.Anarchy)
            {
                packet.Player1ControllerType = 1;
                packet.Player1ControllerKeys |= controller.Buttons;

                packet.Player1LeftStickX += controller.LeftStickX;
                packet.Player1LeftStickY += controller.LeftStickY;
                packet.Player1RightStickX += controller.RightStickX;
                packet.Player1RightStickY += controller.RightStickY;
                return;
            }

            // In Normal mode, all players have their own controller
            switch (controllerIndex)
            {
                case 0:
                    packet.Player1ControllerType = 1;
                    packet.Player1ControllerKeys = controller.Buttons;

                    packet.Player1LeftStickX = controller.LeftStickX;
                    packet.Player1LeftStickY = controller.LeftStickY;
                    packet.Player1RightStickX = controller.RightStickX;
                    packet.Player1RightStickY = controller.RightStickY;
                    break;
                case 1:
                    packet.Player2ControllerType = 1;
                    packet.Player2ControllerKeys = controller.Buttons;

                    packet.Player2LeftStickX = controller.LeftStickX;
                    packet.Player2LeftStickY = controller.LeftStickY;
                    packet.Player2RightStickX = controller.RightStickX;
                    packet.Player2RightStickY = controller.RightStickY;
                    break;
                case 2:
                    packet.Player3ControllerType = 1;
                    packet.Player3ControllerKeys = controller.Buttons;

                    packet.Player3LeftStickX = controller.LeftStickX;
                    packet.Player3LeftStickY = controller.LeftStickY;
                    packet.Player3RightStickX = controller.RightStickX;
                    packet.Player3RightStickY = controller.RightStickY;
                    break;
                case 3:
                    packet.Player4ControllerType = 1;
                    packet.Player4ControllerKeys = controller.Buttons;

                    packet.Player4LeftStickX = controller.LeftStickX;
                    packet.Player4LeftStickY = controller.LeftStickY;
                    packet.Player4RightStickX = controller.RightStickX;
                    packet.Player4RightStickY = controller.RightStickY;
                    break;
            }
        }

        // Source: https://bytes.com/topic/c-sharp/answers/236808-how-convert-structure-byte-array
        private static byte[] StructureToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);

            byte[] arr = new byte[len];

            IntPtr ptr = Marshal.AllocHGlobal(len);

            Marshal.StructureToPtr(obj, ptr, true);

            Marshal.Copy(ptr, arr, 0, len);

            Marshal.FreeHGlobal(ptr);

            return arr;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    class SysHidplusData
    {
        private readonly UInt16 Magic = 0x3276;

        public UInt16 ControllerCount = 4;

        public UInt16 Player1ControllerType = 0;
        public UInt64 Player1ControllerKeys = 0;
        public Int32 Player1LeftStickX = 0;
        public Int32 Player1LeftStickY = 0;
        public Int32 Player1RightStickX = 0;
        public Int32 Player1RightStickY = 0;

        public UInt16 Player2ControllerType = 0;
        public UInt64 Player2ControllerKeys = 0;
        public Int32 Player2LeftStickX = 0;
        public Int32 Player2LeftStickY = 0;
        public Int32 Player2RightStickX = 0;
        public Int32 Player2RightStickY = 0;

        public UInt16 Player3ControllerType = 0;
        public UInt64 Player3ControllerKeys = 0;
        public Int32 Player3LeftStickX = 0;
        public Int32 Player3LeftStickY = 0;
        public Int32 Player3RightStickX = 0;
        public Int32 Player3RightStickY = 0;

        public UInt16 Player4ControllerType = 0;
        public UInt64 Player4ControllerKeys = 0;
        public Int32 Player4LeftStickX = 0;
        public Int32 Player4LeftStickY = 0;
        public Int32 Player4RightStickX = 0;
        public Int32 Player4RightStickY = 0;
    }

    public enum InputMode
    {
        Normal,
        Anarchy
    }
}
