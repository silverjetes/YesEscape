namespace YesEscape
{
    partial class escape_notification
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
            this.components = new System.ComponentModel.Container();
            this.icon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(25, 25);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 32);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "There is an escape...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find the \"Escape\" button on the screen and click it!\r\nYou only have 1 minute.\r\n";
            // 
            // alt
            // 
            this.alt.Location = new System.Drawing.Point(202, 11);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(149, 23);
            this.alt.TabIndex = 3;
            this.alt.Text = "Alternative escape method";
            this.alt.UseVisualStyleBackColor = true;
            this.alt.Click += new System.EventHandler(this.alt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.alt);
            this.panel1.Location = new System.Drawing.Point(-2, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 47);
            this.panel1.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // escape_notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(361, 146);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icon);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 185);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 185);
            this.Name = "escape_notification";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time left: 60s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.escape_notification_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button alt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
    }
}