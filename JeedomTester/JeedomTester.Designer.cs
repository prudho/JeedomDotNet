namespace JeedomTester
{
    partial class JeedomTester
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_API_Key = new System.Windows.Forms.TextBox();
            this.button_Ping = new System.Windows.Forms.Button();
            this.text_Port = new System.Windows.Forms.TextBox();
            this.check_Custom_Port = new System.Windows.Forms.CheckBox();
            this.check_Bypass_SSL = new System.Windows.Forms.CheckBox();
            this.check_Use_SSL = new System.Windows.Forms.CheckBox();
            this.text_Additionnal_Path = new System.Windows.Forms.TextBox();
            this.check_Additionnal_Path = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Host = new System.Windows.Forms.TextBox();
            this.button_Get_Objects = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.text_Raw_Json = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tree_Json = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tree_Objects = new System.Windows.Forms.TreeView();
            this.button_Get_Plugins = new System.Windows.Forms.Button();
            this.button_Get_Eqlogics = new System.Windows.Forms.Button();
            this.button_Get_Commands = new System.Windows.Forms.Button();
            this.entitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.button_Refresh_Entities = new System.Windows.Forms.Button();
            this.button_Get_Scenarios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.entitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_API_Key);
            this.groupBox1.Controls.Add(this.button_Ping);
            this.groupBox1.Controls.Add(this.text_Port);
            this.groupBox1.Controls.Add(this.check_Custom_Port);
            this.groupBox1.Controls.Add(this.check_Bypass_SSL);
            this.groupBox1.Controls.Add(this.check_Use_SSL);
            this.groupBox1.Controls.Add(this.text_Additionnal_Path);
            this.groupBox1.Controls.Add(this.check_Additionnal_Path);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_Host);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "API Key";
            // 
            // text_API_Key
            // 
            this.text_API_Key.Location = new System.Drawing.Point(57, 45);
            this.text_API_Key.Name = "text_API_Key";
            this.text_API_Key.Size = new System.Drawing.Size(134, 20);
            this.text_API_Key.TabIndex = 7;
            // 
            // button_Ping
            // 
            this.button_Ping.Location = new System.Drawing.Point(479, 95);
            this.button_Ping.Name = "button_Ping";
            this.button_Ping.Size = new System.Drawing.Size(75, 23);
            this.button_Ping.TabIndex = 1;
            this.button_Ping.Text = "Test";
            this.button_Ping.UseVisualStyleBackColor = true;
            this.button_Ping.Click += new System.EventHandler(this.button_Ping_Click);
            // 
            // text_Port
            // 
            this.text_Port.Enabled = false;
            this.text_Port.Location = new System.Drawing.Point(154, 92);
            this.text_Port.Name = "text_Port";
            this.text_Port.Size = new System.Drawing.Size(50, 20);
            this.text_Port.TabIndex = 6;
            // 
            // check_Custom_Port
            // 
            this.check_Custom_Port.AutoSize = true;
            this.check_Custom_Port.Location = new System.Drawing.Point(57, 94);
            this.check_Custom_Port.Name = "check_Custom_Port";
            this.check_Custom_Port.Size = new System.Drawing.Size(91, 17);
            this.check_Custom_Port.TabIndex = 1;
            this.check_Custom_Port.Text = "Custom port ?";
            this.check_Custom_Port.UseVisualStyleBackColor = true;
            this.check_Custom_Port.CheckedChanged += new System.EventHandler(this.check_Custom_Port_CheckedChanged);
            // 
            // check_Bypass_SSL
            // 
            this.check_Bypass_SSL.AutoSize = true;
            this.check_Bypass_SSL.Enabled = false;
            this.check_Bypass_SSL.Location = new System.Drawing.Point(163, 71);
            this.check_Bypass_SSL.Name = "check_Bypass_SSL";
            this.check_Bypass_SSL.Size = new System.Drawing.Size(136, 17);
            this.check_Bypass_SSL.TabIndex = 5;
            this.check_Bypass_SSL.Text = "Self-signed certificate ?";
            this.check_Bypass_SSL.UseVisualStyleBackColor = true;
            // 
            // check_Use_SSL
            // 
            this.check_Use_SSL.AutoSize = true;
            this.check_Use_SSL.Location = new System.Drawing.Point(57, 71);
            this.check_Use_SSL.Name = "check_Use_SSL";
            this.check_Use_SSL.Size = new System.Drawing.Size(100, 17);
            this.check_Use_SSL.TabIndex = 4;
            this.check_Use_SSL.Text = "Use SSL (https)";
            this.check_Use_SSL.UseVisualStyleBackColor = true;
            this.check_Use_SSL.CheckedChanged += new System.EventHandler(this.check_Use_SSL_CheckedChanged);
            // 
            // text_Additionnal_Path
            // 
            this.text_Additionnal_Path.Enabled = false;
            this.text_Additionnal_Path.Location = new System.Drawing.Point(314, 19);
            this.text_Additionnal_Path.Name = "text_Additionnal_Path";
            this.text_Additionnal_Path.Size = new System.Drawing.Size(100, 20);
            this.text_Additionnal_Path.TabIndex = 3;
            this.text_Additionnal_Path.Text = "/jeedom";
            // 
            // check_Additionnal_Path
            // 
            this.check_Additionnal_Path.AutoSize = true;
            this.check_Additionnal_Path.Location = new System.Drawing.Point(197, 21);
            this.check_Additionnal_Path.Name = "check_Additionnal_Path";
            this.check_Additionnal_Path.Size = new System.Drawing.Size(111, 17);
            this.check_Additionnal_Path.TabIndex = 2;
            this.check_Additionnal_Path.Text = "Additionnal path ?";
            this.check_Additionnal_Path.UseVisualStyleBackColor = true;
            this.check_Additionnal_Path.CheckedChanged += new System.EventHandler(this.check_Additionnal_Path_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // text_Host
            // 
            this.text_Host.Location = new System.Drawing.Point(57, 19);
            this.text_Host.Name = "text_Host";
            this.text_Host.Size = new System.Drawing.Size(134, 20);
            this.text_Host.TabIndex = 0;
            // 
            // button_Get_Objects
            // 
            this.button_Get_Objects.Location = new System.Drawing.Point(115, 19);
            this.button_Get_Objects.Name = "button_Get_Objects";
            this.button_Get_Objects.Size = new System.Drawing.Size(103, 23);
            this.button_Get_Objects.TabIndex = 2;
            this.button_Get_Objects.Text = "Get objects";
            this.button_Get_Objects.UseVisualStyleBackColor = true;
            this.button_Get_Objects.Click += new System.EventHandler(this.button_Get_Objects_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 230);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 519);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.text_Raw_Json);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raw JSON result";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // text_Raw_Json
            // 
            this.text_Raw_Json.Location = new System.Drawing.Point(6, 6);
            this.text_Raw_Json.Multiline = true;
            this.text_Raw_Json.Name = "text_Raw_Json";
            this.text_Raw_Json.ReadOnly = true;
            this.text_Raw_Json.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Raw_Json.Size = new System.Drawing.Size(540, 481);
            this.text_Raw_Json.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tree_Json);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "JSON explorer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tree_Json
            // 
            this.tree_Json.Location = new System.Drawing.Point(6, 6);
            this.tree_Json.Name = "tree_Json";
            this.tree_Json.Size = new System.Drawing.Size(540, 481);
            this.tree_Json.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tree_Objects);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(552, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Object explorer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tree_Objects
            // 
            this.tree_Objects.Location = new System.Drawing.Point(6, 6);
            this.tree_Objects.Name = "tree_Objects";
            this.tree_Objects.Size = new System.Drawing.Size(540, 484);
            this.tree_Objects.TabIndex = 2;
            // 
            // button_Get_Plugins
            // 
            this.button_Get_Plugins.Location = new System.Drawing.Point(224, 19);
            this.button_Get_Plugins.Name = "button_Get_Plugins";
            this.button_Get_Plugins.Size = new System.Drawing.Size(103, 23);
            this.button_Get_Plugins.TabIndex = 4;
            this.button_Get_Plugins.Text = "Get plugins";
            this.button_Get_Plugins.UseVisualStyleBackColor = true;
            this.button_Get_Plugins.Click += new System.EventHandler(this.button_Get_Plugins_Click);
            // 
            // button_Get_Eqlogics
            // 
            this.button_Get_Eqlogics.Location = new System.Drawing.Point(333, 19);
            this.button_Get_Eqlogics.Name = "button_Get_Eqlogics";
            this.button_Get_Eqlogics.Size = new System.Drawing.Size(103, 23);
            this.button_Get_Eqlogics.TabIndex = 5;
            this.button_Get_Eqlogics.Text = "Get eqlogics";
            this.button_Get_Eqlogics.UseVisualStyleBackColor = true;
            this.button_Get_Eqlogics.Click += new System.EventHandler(this.button_Get_eqlogics_Click);
            // 
            // button_Get_Commands
            // 
            this.button_Get_Commands.Location = new System.Drawing.Point(442, 19);
            this.button_Get_Commands.Name = "button_Get_Commands";
            this.button_Get_Commands.Size = new System.Drawing.Size(103, 23);
            this.button_Get_Commands.TabIndex = 6;
            this.button_Get_Commands.Text = "Get commands";
            this.button_Get_Commands.UseVisualStyleBackColor = true;
            this.button_Get_Commands.Click += new System.EventHandler(this.button_Get_Commands_Click);
            // 
            // entitiesGroupBox
            // 
            this.entitiesGroupBox.Controls.Add(this.button_Get_Scenarios);
            this.entitiesGroupBox.Controls.Add(this.button_Refresh_Entities);
            this.entitiesGroupBox.Controls.Add(this.button_Get_Objects);
            this.entitiesGroupBox.Controls.Add(this.button_Get_Commands);
            this.entitiesGroupBox.Controls.Add(this.button_Get_Plugins);
            this.entitiesGroupBox.Controls.Add(this.button_Get_Eqlogics);
            this.entitiesGroupBox.Enabled = false;
            this.entitiesGroupBox.Location = new System.Drawing.Point(12, 142);
            this.entitiesGroupBox.Name = "entitiesGroupBox";
            this.entitiesGroupBox.Size = new System.Drawing.Size(560, 82);
            this.entitiesGroupBox.TabIndex = 1;
            this.entitiesGroupBox.TabStop = false;
            this.entitiesGroupBox.Text = "Entities";
            // 
            // button_Refresh_Entities
            // 
            this.button_Refresh_Entities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh_Entities.Location = new System.Drawing.Point(6, 19);
            this.button_Refresh_Entities.Name = "button_Refresh_Entities";
            this.button_Refresh_Entities.Size = new System.Drawing.Size(103, 23);
            this.button_Refresh_Entities.TabIndex = 7;
            this.button_Refresh_Entities.Text = "Refresh";
            this.button_Refresh_Entities.UseVisualStyleBackColor = true;
            this.button_Refresh_Entities.Click += new System.EventHandler(this.button_Refresh_Entities_Click);
            // 
            // button_Get_Scenarios
            // 
            this.button_Get_Scenarios.Location = new System.Drawing.Point(115, 48);
            this.button_Get_Scenarios.Name = "button_Get_Scenarios";
            this.button_Get_Scenarios.Size = new System.Drawing.Size(103, 23);
            this.button_Get_Scenarios.TabIndex = 8;
            this.button_Get_Scenarios.Text = "Get scenarios";
            this.button_Get_Scenarios.UseVisualStyleBackColor = true;
            this.button_Get_Scenarios.Click += new System.EventHandler(this.button_Get_Scenarios_Click);
            // 
            // JeedomTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.entitiesGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "JeedomTester";
            this.Text = "JeedomTester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.entitiesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.CheckBox check_Custom_Port;
        private System.Windows.Forms.CheckBox check_Bypass_SSL;
        private System.Windows.Forms.CheckBox check_Use_SSL;
        private System.Windows.Forms.TextBox text_Additionnal_Path;
        private System.Windows.Forms.CheckBox check_Additionnal_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Host;
        private System.Windows.Forms.Button button_Ping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_API_Key;
        private System.Windows.Forms.Button button_Get_Objects;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox text_Raw_Json;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView tree_Json;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView tree_Objects;
        private System.Windows.Forms.Button button_Get_Plugins;
        private System.Windows.Forms.Button button_Get_Eqlogics;
        private System.Windows.Forms.Button button_Get_Commands;
        private System.Windows.Forms.GroupBox entitiesGroupBox;
        private System.Windows.Forms.Button button_Refresh_Entities;
        private System.Windows.Forms.Button button_Get_Scenarios;
    }
}

