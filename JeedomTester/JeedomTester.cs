using JeedomDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeedomTester
{
    public partial class JeedomTester : Form
    {
        Jeedom jee;

        public JeedomTester()
        {
            InitializeComponent();
        }

        private void check_Additionnal_Path_CheckedChanged(object sender, EventArgs e)
        {
            text_Additionnal_Path.Enabled = check_Additionnal_Path.Checked;
        }

        private void check_Use_SSL_CheckedChanged(object sender, EventArgs e)
        {
            check_Bypass_SSL.Enabled = check_Use_SSL.Checked;
        }

        private void check_Custom_Port_CheckedChanged(object sender, EventArgs e)
        {
            text_Port.Enabled = check_Custom_Port.Checked;
        }

        private void Init()
        {
            if (check_Custom_Port.Checked && check_Additionnal_Path.Checked)
            {
                jee = new Jeedom(text_Host.Text, text_Additionnal_Path.Text, int.Parse(text_Port.Text), text_API_Key.Text, check_Use_SSL.Checked, check_Bypass_SSL.Checked);
            }
            else if (check_Custom_Port.Checked)
            {
                jee = new Jeedom(text_Host.Text, int.Parse(text_Port.Text), text_API_Key.Text, check_Use_SSL.Checked, check_Bypass_SSL.Checked);
            }
            else if (check_Additionnal_Path.Checked)
            {
                jee = new Jeedom(text_Host.Text, text_Additionnal_Path.Text, text_API_Key.Text, check_Use_SSL.Checked, check_Bypass_SSL.Checked);
            }
            else
            {
                jee = new Jeedom(text_Host.Text, text_API_Key.Text, check_Use_SSL.Checked, check_Bypass_SSL.Checked);
            }
        }

        private void button_Ping_Click(object sender, EventArgs e)
        {
            this.Init();

            //jee.OnResponse += Jee_OnResponse;

            if (jee.Ping())
            {
                string version = jee.GetVersion();

                MessageBox.Show("Connexion OK !\r\n\r\nJeedom version : " + version);
            }
            else
            {
                MessageBox.Show("Timeout !");
            }
        }

        private void Jee_OnResponse(string message)
        {
            MessageBox.Show(message);
        }
    }
}
