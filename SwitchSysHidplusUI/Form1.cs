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

            //set every layoutStyle to the default Nintendow Sitch button style
            layoutStyle1.SelectedIndex = 0;
            layoutStyle2.SelectedIndex = 0;
            layoutStyle3.SelectedIndex = 0;
            layoutStyle4.SelectedIndex = 0;

            //The ConnectionStatus only loads in the beginning when you start the application so you can see if every controller is connected
            if(UDPManager.controllers[0].Connected)
            {
                connectionStatus1.Text = "Connected"; 
            }
            if (UDPManager.controllers[1].Connected)
            {
                connectionStatus2.Text = "Connected";
            }
            if (UDPManager.controllers[2].Connected)
            {
                connectionStatus3.Text = "Connected";
            }
            if (UDPManager.controllers[3].Connected)
            {
                connectionStatus4.Text = "Connected";
            }

            //Sets layoutStyle of every Controller to 0 (switch Layout)
            UDPManager.controllers[0].layoutStyle = 0;
            UDPManager.controllers[1].layoutStyle = 0;
            UDPManager.controllers[2].layoutStyle = 0;
            UDPManager.controllers[3].layoutStyle = 0;

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void layoutStyle1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(layoutStyle1.SelectedIndex == 0)
            {
                UDPManager.controllers[0].layoutStyle = 0;
            }
            else if(layoutStyle1.SelectedIndex == 1)
            {
                UDPManager.controllers[0].layoutStyle = 1;
            }
        }

        private void layoutStyle2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (layoutStyle2.SelectedIndex == 0)
            {
                UDPManager.controllers[1].layoutStyle = 0;
            }
            else if (layoutStyle2.SelectedIndex == 1)
            {
                UDPManager.controllers[1].layoutStyle = 1;
            }
        }

        private void layoutStyle3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (layoutStyle3.SelectedIndex == 0)
            {
                UDPManager.controllers[2].layoutStyle = 0;
            }
            else if (layoutStyle3.SelectedIndex == 1)
            {
                UDPManager.controllers[2].layoutStyle = 1;
            }
        }

        private void layoutStyle4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (layoutStyle4.SelectedIndex == 0)
            {
                UDPManager.controllers[3].layoutStyle = 0;
            }
            else if (layoutStyle4.SelectedIndex == 1)
            {
                UDPManager.controllers[3].layoutStyle = 1;
            }
        }
    }
}
