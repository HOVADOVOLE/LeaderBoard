namespace Leaderboard
{
    partial class Game
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
            this.panel_gamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_livesFav = new System.Windows.Forms.Panel();
            this.label_scoreCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel_gamePanel
            // 
            this.panel_gamePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_gamePanel.Location = new System.Drawing.Point(248, 12);
            this.panel_gamePanel.Name = "panel_gamePanel";
            this.panel_gamePanel.Size = new System.Drawing.Size(528, 426);
            this.panel_gamePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lives:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score:";
            // 
            // panel_livesFav
            // 
            this.panel_livesFav.Location = new System.Drawing.Point(97, 36);
            this.panel_livesFav.Name = "panel_livesFav";
            this.panel_livesFav.Size = new System.Drawing.Size(145, 35);
            this.panel_livesFav.TabIndex = 3;
            // 
            // label_scoreCount
            // 
            this.label_scoreCount.AutoSize = true;
            this.label_scoreCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_scoreCount.Location = new System.Drawing.Point(157, 383);
            this.label_scoreCount.Name = "label_scoreCount";
            this.label_scoreCount.Size = new System.Drawing.Size(38, 46);
            this.label_scoreCount.TabIndex = 4;
            this.label_scoreCount.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_scoreCount);
            this.Controls.Add(this.panel_livesFav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_gamePanel);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label_scoreCount;
        internal Panel panel_gamePanel;
        private System.Windows.Forms.Timer timer1;
        internal Panel panel_livesFav;
    }
}