﻿namespace YesEscape
{
    partial class Escape
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
            this.esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // esc
            // 
            this.esc.BackColor = System.Drawing.Color.White;
            this.esc.Location = new System.Drawing.Point(0, 0);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(155, 54);
            this.esc.TabIndex = 0;
            this.esc.Text = "Escape";
            this.esc.UseVisualStyleBackColor = false;
            this.esc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.esc_MouseClick);
            this.esc.MouseEnter += new System.EventHandler(this.esc_MouseEnter);
            // 
            // Escape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(155, 54);
            this.ControlBox = false;
            this.Controls.Add(this.esc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Escape";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "There is an escape...";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button esc;
    }
}