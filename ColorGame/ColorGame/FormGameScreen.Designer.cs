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
            this.panelGameFields = new System.Windows.Forms.Panel();
            this.panelPlayer1Moves = new System.Windows.Forms.Panel();
            this.panelPlayer2Moves = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelPlayer2Scores = new System.Windows.Forms.Label();
            this.labelPlayer1Scores = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGameFields
            // 
            this.panelGameFields.Location = new System.Drawing.Point(107, 12);
            this.panelGameFields.Name = "panelGameFields";
            this.panelGameFields.Size = new System.Drawing.Size(534, 469);
            this.panelGameFields.TabIndex = 0;
            this.panelGameFields.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelPlayer1Moves
            // 
            this.panelPlayer1Moves.Location = new System.Drawing.Point(13, 40);
            this.panelPlayer1Moves.Name = "panelPlayer1Moves";
            this.panelPlayer1Moves.Size = new System.Drawing.Size(70, 358);
            this.panelPlayer1Moves.TabIndex = 1;
            this.panelPlayer1Moves.Click += new System.EventHandler(this.player1Moves_Click);
            this.panelPlayer1Moves.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAvalible1_Paint);
            // 
            // panelPlayer2Moves
            // 
            this.panelPlayer2Moves.Location = new System.Drawing.Point(647, 40);
            this.panelPlayer2Moves.Name = "panelPlayer2Moves";
            this.panelPlayer2Moves.Size = new System.Drawing.Size(81, 358);
            this.panelPlayer2Moves.TabIndex = 2;
            this.panelPlayer2Moves.Click += new System.EventHandler(this.panel_Player2_Moves_Click);
            this.panelPlayer2Moves.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_AvalibleMove_forPlayer_2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступные ходы\r\n для игрока 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Доступные ходы\r\n для игрока 2\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(747, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Player 1 Move";
            // 
            // labelPlayer2Scores
            // 
            this.labelPlayer2Scores.AutoSize = true;
            this.labelPlayer2Scores.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Scores.Location = new System.Drawing.Point(689, 421);
            this.labelPlayer2Scores.Name = "labelPlayer2Scores";
            this.labelPlayer2Scores.Size = new System.Drawing.Size(39, 42);
            this.labelPlayer2Scores.TabIndex = 5;
            this.labelPlayer2Scores.Text = "0";
            // 
            // labelPlayer1Scores
            // 
            this.labelPlayer1Scores.AutoSize = true;
            this.labelPlayer1Scores.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Scores.Location = new System.Drawing.Point(44, 421);
            this.labelPlayer1Scores.Name = "labelPlayer1Scores";
            this.labelPlayer1Scores.Size = new System.Drawing.Size(39, 42);
            this.labelPlayer1Scores.TabIndex = 6;
            this.labelPlayer1Scores.Text = "0";
            // 
            // FormGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 506);
            this.Controls.Add(this.labelPlayer1Scores);
            this.Controls.Add(this.labelPlayer2Scores);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelPlayer2Moves);
            this.Controls.Add(this.panelPlayer1Moves);
            this.Controls.Add(this.panelGameFields);
            this.Name = "FormGameScreen";
            this.Text = "FormGameScreen";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGameFields;
        private System.Windows.Forms.Panel panelPlayer1Moves;
        private System.Windows.Forms.Panel panelPlayer2Moves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelPlayer2Scores;
        private System.Windows.Forms.Label labelPlayer1Scores;
    }
}