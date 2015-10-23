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
            this.button_Ping = new System.Windows.Forms.Button();
            this.text_Port = new System.Windows.Forms.TextBox();
            this.check_Custom_Port = new System.Windows.Forms.CheckBox();
            this.check_Bypass_SSL = new System.Windows.Forms.CheckBox();
            this.check_Use_SSL = new System.Windows.Forms.CheckBox();
            this.text_Additionnal_Path = new System.Windows.Forms.TextBox();
            this.check_Additionnal_Path = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_API_Key = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.text_Additionnal_Path.Text = "/";
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
            // JeedomTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "JeedomTester";
            this.Text = "JeedomTester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

