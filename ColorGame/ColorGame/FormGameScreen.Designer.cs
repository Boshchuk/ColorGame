﻿namespace ColorGame
{
    partial class FormGameScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(107, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 387);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 358);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(871, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 341);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступные ходы\r\n для игрока 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(871, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Доступные ходы\r\n для игрока 2\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGameScreen";
            this.Text = "FormGameScreen";
            this.Load += new System.EventHandler(this.FormGameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}