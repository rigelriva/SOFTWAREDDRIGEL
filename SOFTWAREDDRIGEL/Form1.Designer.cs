namespace SOFTWAREDDRIGEL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardbutton = new System.Windows.Forms.Button();
            this.infobutton = new System.Windows.Forms.Button();
            this.settingsbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboard1 = new SOFTWAREDDRIGEL.DASHBOARD();
            this.info1 = new SOFTWAREDDRIGEL.info();
            this.settings1 = new SOFTWAREDDRIGEL.settings();
            this.login1 = new SOFTWAREDDRIGEL.login();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardbutton
            // 
            this.dashboardbutton.Location = new System.Drawing.Point(0, 0);
            this.dashboardbutton.Name = "dashboardbutton";
            this.dashboardbutton.Size = new System.Drawing.Size(200, 85);
            this.dashboardbutton.TabIndex = 0;
            this.dashboardbutton.Text = "DASHBOARD";
            this.dashboardbutton.UseVisualStyleBackColor = true;
            this.dashboardbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // infobutton
            // 
            this.infobutton.Location = new System.Drawing.Point(0, 232);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(200, 99);
            this.infobutton.TabIndex = 1;
            this.infobutton.Text = "INFO";
            this.infobutton.UseVisualStyleBackColor = true;
            this.infobutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsbutton
            // 
            this.settingsbutton.Location = new System.Drawing.Point(0, 108);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(200, 95);
            this.settingsbutton.TabIndex = 2;
            this.settingsbutton.Text = "SETTINGS";
            this.settingsbutton.UseVisualStyleBackColor = true;
            this.settingsbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dashboardbutton);
            this.panel1.Controls.Add(this.infobutton);
            this.panel1.Controls.Add(this.settingsbutton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1007);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 944);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(206, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1386, 1007);
            this.dashboard1.TabIndex = 6;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.White;
            this.info1.Location = new System.Drawing.Point(206, 0);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(1386, 1007);
            this.info1.TabIndex = 5;
            // 
            // settings1
            // 
            this.settings1.Location = new System.Drawing.Point(206, 0);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(1386, 1007);
            this.settings1.TabIndex = 4;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.White;
            this.login1.Location = new System.Drawing.Point(-11, -23);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1623, 1043);
            this.login1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1591, 1007);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dashboardbutton;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.Button settingsbutton;
        private System.Windows.Forms.Panel panel1;
        private settings settings1;
        private info info1;
        private System.Windows.Forms.Button button1;
        private DASHBOARD dashboard1;
        private login login1;
    }
}

