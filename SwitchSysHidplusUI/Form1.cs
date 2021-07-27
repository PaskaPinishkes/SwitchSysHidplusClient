using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwitchSysHidplusClient;

namespace SwitchSysHidplusUI
{
    public partial class Form1 : Form
    {
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            modeComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                UDPManager.StopNetworkLoop();

                button1.Text = "Connect to Switch";
                ipTextBox.Enabled = true;
                modeComboBox.Enabled = true;

                isConnected = false;
            } else {
                try
                {
                    UDPManager.ChangeIPAddress(ipTextBox.Text);
                    UDPManager.StartNetworkLoop();

                    button1.Text = "Disconnect";
                    ipTextBox.Enabled = false;
                    modeComboBox.Enabled = false;

                    isConnected = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error: " + exception.ToString());
                }
            }
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(modeComboBox.SelectedIndex);
            if (modeComboBox.SelectedIndex == 0)
                UDPManager.Mode = InputMode.Normal;
            else if (modeComboBox.SelectedIndex == 1)
                UDPManager.Mode = InputMode.Anarchy;
        }
    }
}
