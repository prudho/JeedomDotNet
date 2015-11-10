using JeedomDotNet;
using Newtonsoft.Json.Linq;
using System;
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

            jee.OnResponse += Jee_OnResponse;

            jee.Load();
        }

        private void button_Ping_Click(object sender, EventArgs e)
        {
            this.Init();

            if (jee.Loaded)
            {
                string version = jee.Version;

                MessageBox.Show("Connexion OK !\r\n\r\nJeedom version : " + version, "Connexion OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                entitiesGroupBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erreur à la connexion : " + jee.Error, "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                entitiesGroupBox.Enabled = false;
            }
        }

        private void Jee_OnResponse(string message)
        {
            text_Raw_Json.Text += JsonHelper.FormatJson(message) + "\r\n";
        }

        private void button_Get_Objects_Click(object sender, EventArgs e)
        {
            Init();

            text_Raw_Json.Text = JsonHelper.FormatJson(jee.Entities.Objects.InnerJson);
            tree_Json.Nodes.Clear();
            tree_Objects.Nodes.Clear();

            tree_Json.Nodes.Add(JsonHelper.Json2Tree(JObject.Parse(jee.Entities.Objects.InnerJson)));
            tree_Objects.Nodes.Add(ObjectHelper.CreateTree(jee.Entities.Objects));
        }

        private void button_Get_Plugins_Click(object sender, EventArgs e)
        {
            Init();

            text_Raw_Json.Text = JsonHelper.FormatJson(jee.Entities.Plugins.InnerJson);
            tree_Json.Nodes.Clear();
            tree_Objects.Nodes.Clear();

            tree_Json.Nodes.Add(JsonHelper.Json2Tree(JObject.Parse(jee.Entities.Plugins.InnerJson)));
            tree_Objects.Nodes.Add(ObjectHelper.CreateTree(jee.Entities.Plugins));
        }

        private void button_Get_eqlogics_Click(object sender, EventArgs e)
        {
            Init();

            text_Raw_Json.Text = JsonHelper.FormatJson(jee.Entities.EqLogics.InnerJson);
            tree_Json.Nodes.Clear();
            tree_Objects.Nodes.Clear();

            tree_Json.Nodes.Add(JsonHelper.Json2Tree(JObject.Parse(jee.Entities.EqLogics.InnerJson)));
            tree_Objects.Nodes.Add(ObjectHelper.CreateTree(jee.Entities.EqLogics));
        }

        private void button_Get_Commands_Click(object sender, EventArgs e)
        {
            Init();

            text_Raw_Json.Text = JsonHelper.FormatJson(jee.Entities.Commands.InnerJson);
            tree_Json.Nodes.Clear();
            tree_Objects.Nodes.Clear();

            tree_Json.Nodes.Add(JsonHelper.Json2Tree(JObject.Parse(jee.Entities.Commands.InnerJson)));
            tree_Objects.Nodes.Add(ObjectHelper.CreateTree(jee.Entities.Commands));
        }

        private void button_Refresh_Entities_Click(object sender, EventArgs e)
        {
            text_Raw_Json.Text = "";

            jee.Entities.Refresh();
        }

        private void button_Get_Scenarios_Click(object sender, EventArgs e)
        {
            Init();

            text_Raw_Json.Text = JsonHelper.FormatJson(jee.Entities.Scenarios.InnerJson);
            tree_Json.Nodes.Clear();
            tree_Objects.Nodes.Clear();

            tree_Json.Nodes.Add(JsonHelper.Json2Tree(JObject.Parse(jee.Entities.Scenarios.InnerJson)));
            tree_Objects.Nodes.Add(ObjectHelper.CreateTree(jee.Entities.Scenarios));
        }
    }
}
