namespace WinForms_Game
{
    partial class mainForm2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerUnit = new System.Windows.Forms.PictureBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.armorCounter = new System.Windows.Forms.Label();
            this.swordCounter = new System.Windows.Forms.Label();
            this.armorIcon = new System.Windows.Forms.PictureBox();
            this.swordIcon = new System.Windows.Forms.PictureBox();
            this.manaCounter = new System.Windows.Forms.Label();
            this.manaIcon = new System.Windows.Forms.PictureBox();
            this.coinCounter = new System.Windows.Forms.Label();
            this.coinIcon = new System.Windows.Forms.PictureBox();
            this.hpLabel = new System.Windows.Forms.Label();
            this.progressBarHP = new System.Windows.Forms.ProgressBar();
            this.xCounter = new System.Windows.Forms.Label();
            this.xP = new System.Windows.Forms.Label();
            this.yCounter = new System.Windows.Forms.Label();
            this.yP = new System.Windows.Forms.Label();
            this.nulCoordinate = new System.Windows.Forms.Label();
            this.dirP = new System.Windows.Forms.Label();
            this.dirPointer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerUnit)).BeginInit();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // playerUnit
            // 
            this.playerUnit.BackColor = System.Drawing.Color.Transparent;
            this.playerUnit.Image = global::WinForms_Game.Properties.Resources.playerSkin;
            this.playerUnit.Location = new System.Drawing.Point(321, 206);
            this.playerUnit.Name = "playerUnit";
            this.playerUnit.Size = new System.Drawing.Size(140, 140);
            this.playerUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerUnit.TabIndex = 0;
            this.playerUnit.TabStop = false;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statsPanel.Controls.Add(this.armorCounter);
            this.statsPanel.Controls.Add(this.swordCounter);
            this.statsPanel.Controls.Add(this.armorIcon);
            this.statsPanel.Controls.Add(this.swordIcon);
            this.statsPanel.Controls.Add(this.manaCounter);
            this.statsPanel.Controls.Add(this.manaIcon);
            this.statsPanel.Controls.Add(this.coinCounter);
            this.statsPanel.Controls.Add(this.coinIcon);
            this.statsPanel.Controls.Add(this.hpLabel);
            this.statsPanel.Controls.Add(this.progressBarHP);
            this.statsPanel.Location = new System.Drawing.Point(514, 375);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(256, 166);
            this.statsPanel.TabIndex = 1;
            // 
            // armorCounter
            // 
            this.armorCounter.AutoSize = true;
            this.armorCounter.Location = new System.Drawing.Point(214, 137);
            this.armorCounter.Name = "armorCounter";
            this.armorCounter.Size = new System.Drawing.Size(16, 17);
            this.armorCounter.TabIndex = 9;
            this.armorCounter.Text = "0";
            // 
            // swordCounter
            // 
            this.swordCounter.AutoSize = true;
            this.swordCounter.Location = new System.Drawing.Point(50, 137);
            this.swordCounter.Name = "swordCounter";
            this.swordCounter.Size = new System.Drawing.Size(16, 17);
            this.swordCounter.TabIndex = 8;
            this.swordCounter.Text = "0";
            // 
            // armorIcon
            // 
            this.armorIcon.Image = global::WinForms_Game.Properties.Resources.shield;
            this.armorIcon.Location = new System.Drawing.Point(168, 123);
            this.armorIcon.Name = "armorIcon";
            this.armorIcon.Size = new System.Drawing.Size(40, 40);
            this.armorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.armorIcon.TabIndex = 7;
            this.armorIcon.TabStop = false;
            // 
            // swordIcon
            // 
            this.swordIcon.Image = global::WinForms_Game.Properties.Resources.sword;
            this.swordIcon.Location = new System.Drawing.Point(4, 123);
            this.swordIcon.Name = "swordIcon";
            this.swordIcon.Size = new System.Drawing.Size(40, 40);
            this.swordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordIcon.TabIndex = 6;
            this.swordIcon.TabStop = false;
            // 
            // manaCounter
            // 
            this.manaCounter.AutoSize = true;
            this.manaCounter.Location = new System.Drawing.Point(215, 76);
            this.manaCounter.Name = "manaCounter";
            this.manaCounter.Size = new System.Drawing.Size(16, 17);
            this.manaCounter.TabIndex = 5;
            this.manaCounter.Text = "0";
            // 
            // manaIcon
            // 
            this.manaIcon.Image = global::WinForms_Game.Properties.Resources.mamaIcon;
            this.manaIcon.Location = new System.Drawing.Point(168, 64);
            this.manaIcon.Name = "manaIcon";
            this.manaIcon.Size = new System.Drawing.Size(40, 40);
            this.manaIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manaIcon.TabIndex = 4;
            this.manaIcon.TabStop = false;
            // 
            // coinCounter
            // 
            this.coinCounter.AutoSize = true;
            this.coinCounter.Location = new System.Drawing.Point(50, 77);
            this.coinCounter.Name = "coinCounter";
            this.coinCounter.Size = new System.Drawing.Size(16, 17);
            this.coinCounter.TabIndex = 3;
            this.coinCounter.Text = "0";
            // 
            // coinIcon
            // 
            this.coinIcon.Image = global::WinForms_Game.Properties.Resources.coin;
            this.coinIcon.Location = new System.Drawing.Point(4, 64);
            this.coinIcon.Name = "coinIcon";
            this.coinIcon.Size = new System.Drawing.Size(40, 40);
            this.coinIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinIcon.TabIndex = 2;
            this.coinIcon.TabStop = false;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(115, 14);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(27, 17);
            this.hpLabel.TabIndex = 1;
            this.hpLabel.Text = "HP";
            // 
            // progressBarHP
            // 
            this.progressBarHP.Location = new System.Drawing.Point(4, 34);
            this.progressBarHP.Maximum = 150;
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.Size = new System.Drawing.Size(249, 23);
            this.progressBarHP.TabIndex = 0;
            // 
            // xCounter
            // 
            this.xCounter.AutoSize = true;
            this.xCounter.Location = new System.Drawing.Point(724, 13);
            this.xCounter.Name = "xCounter";
            this.xCounter.Size = new System.Drawing.Size(32, 17);
            this.xCounter.TabIndex = 2;
            this.xCounter.Text = "000";
            // 
            // xP
            // 
            this.xP.AutoSize = true;
            this.xP.Location = new System.Drawing.Point(697, 13);
            this.xP.Name = "xP";
            this.xP.Size = new System.Drawing.Size(21, 17);
            this.xP.TabIndex = 3;
            this.xP.Text = "X:";
            // 
            // yCounter
            // 
            this.yCounter.AutoSize = true;
            this.yCounter.Location = new System.Drawing.Point(724, 39);
            this.yCounter.Name = "yCounter";
            this.yCounter.Size = new System.Drawing.Size(32, 17);
            this.yCounter.TabIndex = 4;
            this.yCounter.Text = "000";
            // 
            // yP
            // 
            this.yP.AutoSize = true;
            this.yP.Location = new System.Drawing.Point(697, 39);
            this.yP.Name = "yP";
            this.yP.Size = new System.Drawing.Size(21, 17);
            this.yP.TabIndex = 5;
            this.yP.Text = "Y:";
            // 
            // nulCoordinate
            // 
            this.nulCoordinate.AutoSize = true;
            this.nulCoordinate.Location = new System.Drawing.Point(321, 206);
            this.nulCoordinate.Name = "nulCoordinate";
            this.nulCoordinate.Size = new System.Drawing.Size(65, 17);
            this.nulCoordinate.TabIndex = 6;
            this.nulCoordinate.Text = "nulCoord";
            this.nulCoordinate.Visible = false;
            // 
            // dirP
            // 
            this.dirP.AutoSize = true;
            this.dirP.Location = new System.Drawing.Point(686, 65);
            this.dirP.Name = "dirP";
            this.dirP.Size = new System.Drawing.Size(32, 17);
            this.dirP.TabIndex = 7;
            this.dirP.Text = "DR:";
            // 
            // dirPointer
            // 
            this.dirPointer.AutoSize = true;
            this.dirPointer.Location = new System.Drawing.Point(725, 65);
            this.dirPointer.Name = "dirPointer";
            this.dirPointer.Size = new System.Drawing.Size(27, 17);
            this.dirPointer.TabIndex = 8;
            this.dirPointer.Text = "UP";
            // 
            // mainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForms_Game.Properties.Resources.backGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.dirPointer);
            this.Controls.Add(this.dirP);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.playerUnit);
            this.Controls.Add(this.nulCoordinate);
            this.Controls.Add(this.yP);
            this.Controls.Add(this.yCounter);
            this.Controls.Add(this.xP);
            this.Controls.Add(this.xCounter);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm2";
            this.Text = "WinForms Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controlButtonPressed);
            ((System.ComponentModel.ISupportInitialize)(this.playerUnit)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerUnit;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.ProgressBar progressBarHP;
        private System.Windows.Forms.PictureBox coinIcon;
        private System.Windows.Forms.Label coinCounter;
        private System.Windows.Forms.PictureBox manaIcon;
        private System.Windows.Forms.Label manaCounter;
        private System.Windows.Forms.Label xCounter;
        private System.Windows.Forms.Label xP;
        private System.Windows.Forms.Label yCounter;
        private System.Windows.Forms.Label yP;
        private System.Windows.Forms.Label nulCoordinate;
        private System.Windows.Forms.Label armorCounter;
        private System.Windows.Forms.Label swordCounter;
        private System.Windows.Forms.PictureBox armorIcon;
        private System.Windows.Forms.PictureBox swordIcon;
        private System.Windows.Forms.Label dirP;
        private System.Windows.Forms.Label dirPointer;

        
        //this.wall.Image = global::WinForms_Game.Properties.Resources.wall_texture;
        //this.wall.Location = new System.Drawing.Point(143, 147);
        //this.wall.Name = "wall";
        //this.wall.Size = new System.Drawing.Size(100, 100);
        //this.wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        //this.wall.TabIndex = 9;
        //this.wall.TabStop = false;
    }
}

