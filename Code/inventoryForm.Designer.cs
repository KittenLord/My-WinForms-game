namespace WinForms_Game
{
    partial class inventoryForm
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
            this.manaPotionInventoryCount = new System.Windows.Forms.Label();
            this.healPotionInventoryCount = new System.Windows.Forms.Label();
            this.coinInventoryCount = new System.Windows.Forms.Label();
            this.magicFruitInventoryCount = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.killsCount = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.killsAtm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.killsAll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manaPotionInventoryCount
            // 
            this.manaPotionInventoryCount.AutoSize = true;
            this.manaPotionInventoryCount.BackColor = System.Drawing.Color.Transparent;
            this.manaPotionInventoryCount.Font = new System.Drawing.Font("gitchgitch", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaPotionInventoryCount.Location = new System.Drawing.Point(105, 80);
            this.manaPotionInventoryCount.Name = "manaPotionInventoryCount";
            this.manaPotionInventoryCount.Size = new System.Drawing.Size(31, 32);
            this.manaPotionInventoryCount.TabIndex = 4;
            this.manaPotionInventoryCount.Text = "0";
            // 
            // healPotionInventoryCount
            // 
            this.healPotionInventoryCount.AutoSize = true;
            this.healPotionInventoryCount.Font = new System.Drawing.Font("gitchgitch", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healPotionInventoryCount.Location = new System.Drawing.Point(239, 80);
            this.healPotionInventoryCount.Name = "healPotionInventoryCount";
            this.healPotionInventoryCount.Size = new System.Drawing.Size(31, 32);
            this.healPotionInventoryCount.TabIndex = 5;
            this.healPotionInventoryCount.Text = "0";
            // 
            // coinInventoryCount
            // 
            this.coinInventoryCount.AutoSize = true;
            this.coinInventoryCount.Font = new System.Drawing.Font("gitchgitch", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinInventoryCount.Location = new System.Drawing.Point(251, 209);
            this.coinInventoryCount.Name = "coinInventoryCount";
            this.coinInventoryCount.Size = new System.Drawing.Size(31, 32);
            this.coinInventoryCount.TabIndex = 6;
            this.coinInventoryCount.Text = "0";
            // 
            // magicFruitInventoryCount
            // 
            this.magicFruitInventoryCount.AutoSize = true;
            this.magicFruitInventoryCount.BackColor = System.Drawing.Color.Transparent;
            this.magicFruitInventoryCount.Font = new System.Drawing.Font("gitchgitch", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicFruitInventoryCount.Location = new System.Drawing.Point(105, 209);
            this.magicFruitInventoryCount.Name = "magicFruitInventoryCount";
            this.magicFruitInventoryCount.Size = new System.Drawing.Size(31, 32);
            this.magicFruitInventoryCount.TabIndex = 7;
            this.magicFruitInventoryCount.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinForms_Game.Properties.Resources.magicFruit;
            this.pictureBox4.Location = new System.Drawing.Point(24, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.magicFruitUsed);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinForms_Game.Properties.Resources.coin1;
            this.pictureBox3.Location = new System.Drawing.Point(158, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinForms_Game.Properties.Resources.healPotion;
            this.pictureBox2.Location = new System.Drawing.Point(158, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.healPotionUsed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms_Game.Properties.Resources.manaPotion;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.manaPotionUsed);
            // 
            // killsCount
            // 
            this.killsCount.Location = new System.Drawing.Point(291, 117);
            this.killsCount.Maximum = 35;
            this.killsCount.Name = "killsCount";
            this.killsCount.Size = new System.Drawing.Size(427, 124);
            this.killsCount.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("gitchgitch", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Game Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "You have killed ";
            // 
            // killsAtm
            // 
            this.killsAtm.AutoSize = true;
            this.killsAtm.Font = new System.Drawing.Font("gitchgitch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.killsAtm.Location = new System.Drawing.Point(480, 74);
            this.killsAtm.Name = "killsAtm";
            this.killsAtm.Size = new System.Drawing.Size(21, 23);
            this.killsAtm.TabIndex = 11;
            this.killsAtm.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "mobs out of";
            // 
            // killsAll
            // 
            this.killsAll.AutoSize = true;
            this.killsAll.Font = new System.Drawing.Font("gitchgitch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.killsAll.Location = new System.Drawing.Point(595, 73);
            this.killsAll.Name = "killsAll";
            this.killsAll.Size = new System.Drawing.Size(32, 23);
            this.killsAll.TabIndex = 13;
            this.killsAll.Text = "35";
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 253);
            this.Controls.Add(this.killsAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.killsAtm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.killsCount);
            this.Controls.Add(this.magicFruitInventoryCount);
            this.Controls.Add(this.coinInventoryCount);
            this.Controls.Add(this.healPotionInventoryCount);
            this.Controls.Add(this.manaPotionInventoryCount);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "inventoryForm";
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label manaPotionInventoryCount;
        private System.Windows.Forms.Label healPotionInventoryCount;
        private System.Windows.Forms.Label coinInventoryCount;
        private System.Windows.Forms.Label magicFruitInventoryCount;
        private System.Windows.Forms.ProgressBar killsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label killsAtm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label killsAll;
    }
}