namespace SOFTWAREDDRIGEL
{
    partial class DASHBOARD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clozE_PASSAGE1 = new SOFTWAREDDRIGEL.CLOZE_PASSAGE();
            this.multiplE_CHOICE1 = new SOFTWAREDDRIGEL.MULTIPLE_CHOICE();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(963, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 165);
            this.button1.TabIndex = 1;
            this.button1.Text = "MULTIPLE CHOICE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.activity1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to the Dashboard!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(963, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(385, 165);
            this.button2.TabIndex = 3;
            this.button2.Text = "CLOZE PASSAGE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 931);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(963, 653);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(385, 165);
            this.button4.TabIndex = 6;
            this.button4.Text = "FLASHCARDS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // clozE_PASSAGE1
            // 
            this.clozE_PASSAGE1.BackColor = System.Drawing.Color.White;
            this.clozE_PASSAGE1.Location = new System.Drawing.Point(-38, 12);
            this.clozE_PASSAGE1.Name = "clozE_PASSAGE1";
            this.clozE_PASSAGE1.Size = new System.Drawing.Size(1582, 1039);
            this.clozE_PASSAGE1.TabIndex = 7;
            this.clozE_PASSAGE1.Visible = false;
            // 
            // multiplE_CHOICE1
            // 
            this.multiplE_CHOICE1.BackColor = System.Drawing.Color.White;
            this.multiplE_CHOICE1.Location = new System.Drawing.Point(-15, 0);
            this.multiplE_CHOICE1.Name = "multiplE_CHOICE1";
            this.multiplE_CHOICE1.Size = new System.Drawing.Size(1597, 1051);
            this.multiplE_CHOICE1.TabIndex = 4;
            this.multiplE_CHOICE1.Visible = false;
            // 
            // DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clozE_PASSAGE1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.multiplE_CHOICE1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Name = "DASHBOARD";
            this.Size = new System.Drawing.Size(1582, 1042);
            this.Load += new System.EventHandler(this.DASHBOARD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private MULTIPLE_CHOICE multiplE_CHOICE1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private CLOZE_PASSAGE clozE_PASSAGE1;
    }
}
