using System;
using SwitchSysHidplusClient.Enums;

namespace SwitchSysHidplusClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPManager.ChangeIPAddress("192.168.100.25");
            UDPManager.Mode = InputMode.Anarchy;
            UDPManager.StartNetworkLoop();

            // Exit the program once a key is pressed
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}