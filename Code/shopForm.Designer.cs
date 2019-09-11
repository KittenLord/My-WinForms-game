namespace WinForms_Game
{
    partial class shopForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.armorBuy = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.manaBuy = new System.Windows.Forms.PictureBox();
            this.swordBuy = new System.Windows.Forms.PictureBox();
            this.magicBuy = new System.Windows.Forms.PictureBox();
            this.healBuy = new System.Windows.Forms.PictureBox();
            this.coinCount = new System.Windows.Forms.Label();
            this.manaPrice = new System.Windows.Forms.Label();
            this.healPrice = new System.Windows.Forms.Label();
            this.magicfPrice = new System.Windows.Forms.Label();
            this.swordPrice = new System.Windows.Forms.Label();
            this.armorPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.armorBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shop";
            // 
            // armorBuy
            // 
            this.armorBuy.Image = global::WinForms_Game.Properties.Resources.shield;
            this.armorBuy.Location = new System.Drawing.Point(358, 155);
            this.armorBuy.Name = "armorBuy";
            this.armorBuy.Size = new System.Drawing.Size(100, 100);
            this.armorBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.armorBuy.TabIndex = 5;
            this.armorBuy.TabStop = false;
            this.armorBuy.Click += new System.EventHandler(this.ArmorBuy_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WinForms_Game.Properties.Resources.coin;
            this.pictureBox5.Location = new System.Drawing.Point(182, 307);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // manaBuy
            // 
            this.manaBuy.Image = global::WinForms_Game.Properties.Resources.manaPotion;
            this.manaBuy.Location = new System.Drawing.Point(13, 155);
            this.manaBuy.Name = "manaBuy";
            this.manaBuy.Size = new System.Drawing.Size(100, 100);
            this.manaBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manaBuy.TabIndex = 3;
            this.manaBuy.TabStop = false;
            this.manaBuy.Click += new System.EventHandler(this.ManaBuy_Click);
            // 
            // swordBuy
            // 
            this.swordBuy.Image = global::WinForms_Game.Properties.Resources.sword;
            this.swordBuy.Location = new System.Drawing.Point(358, 13);
            this.swordBuy.Name = "swordBuy";
            this.swordBuy.Size = new System.Drawing.Size(100, 100);
            this.swordBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordBuy.TabIndex = 2;
            this.swordBuy.TabStop = false;
            this.swordBuy.Click += new System.EventHandler(this.SwordBuy_Click);
            // 
            // magicBuy
            // 
            this.magicBuy.Image = global::WinForms_Game.Properties.Resources.magicFruit;
            this.magicBuy.Location = new System.Drawing.Point(182, 13);
            this.magicBuy.Name = "magicBuy";
            this.magicBuy.Size = new System.Drawing.Size(100, 100);
            this.magicBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magicBuy.TabIndex = 1;
            this.magicBuy.TabStop = false;
            this.magicBuy.Click += new System.EventHandler(this.MagicBuy_Click);
            // 
            // healBuy
            // 
            this.healBuy.Image = global::WinForms_Game.Properties.Resources.healPotion;
            this.healBuy.Location = new System.Drawing.Point(13, 13);
            this.healBuy.Name = "healBuy";
            this.healBuy.Size = new System.Drawing.Size(100, 100);
            this.healBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.healBuy.TabIndex = 0;
            this.healBuy.TabStop = false;
            this.healBuy.Click += new System.EventHandler(this.HealBuy_Click);
            // 
            // coinCount
            // 
            this.coinCount.AutoSize = true;
            this.coinCount.Font = new System.Drawing.Font("gitchgitch", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coinCount.Location = new System.Drawing.Point(288, 361);
            this.coinCount.Name = "coinCount";
            this.coinCount.Size = new System.Drawing.Size(43, 46);
            this.coinCount.TabIndex = 7;
            this.coinCount.Text = "0";
            // 
            // manaPrice
            // 
            this.manaPrice.AutoSize = true;
            this.manaPrice.Font = new System.Drawing.Font("gitchgitch", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manaPrice.Location = new System.Drawing.Point(119, 209);
            this.manaPrice.Name = "manaPrice";
            this.manaPrice.Size = new System.Drawing.Size(66, 46);
            this.manaPrice.TabIndex = 8;
            this.manaPrice.Text = "45";
            // 
            // healPrice
            // 
            this.healPrice.AutoSize = true;
            this.healPrice.Font = new System.Drawing.Font("gitchgitch", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healPrice.Location = new System.Drawing.Point(119, 67);
            this.healPrice.Name = "healPrice";
            this.healPrice.Size = new System.Drawing.Size(66, 46);
            this.healPrice.TabIndex = 9;
            this.healPrice.Text = "30";
            // 
            // magicfPrice
            // 
            this.magicfPrice.AutoSize = true;
            this.magicfPrice.Font = new System.Drawing.Font("gitchgitch", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.magicfPrice.Location = new System.Drawing.Point(288, 67);
            this.magicfPrice.Name = "magicfPrice";
            this.magicfPrice.Size = new System.Drawing.Size(51, 46);
            this.magicfPrice.TabIndex = 10;
            this.magicfPrice.Text = "10";
            // 
            // swordPrice
            // 
            this.swordPrice.AutoSize = true;
            this.swordPrice.Font = new System.Drawing.Font("gitchgitch", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.swordPrice.Location = new System.Drawing.Point(376, 116);
            this.swordPrice.Name = "swordPrice";
            this.swordPrice.Size = new System.Drawing.Size(66, 46);
            this.swordPrice.TabIndex = 11;
            this.swordPrice.Text = "20";
            // 
            // armorPrice
            // 
            this.armorPrice.AutoSize = true;
            this.armorPrice.Font = new System.Drawing.Font("gitchgitch", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.armorPrice.Location = new System.Drawing.Point(376, 258);
            this.armorPrice.Name = "armorPrice";
            this.armorPrice.Size = new System.Drawing.Size(66, 46);
            this.armorPrice.TabIndex = 12;
            this.armorPrice.Text = "20";
            // 
            // shopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 419);
            this.Controls.Add(this.armorPrice);
            this.Controls.Add(this.swordPrice);
            this.Controls.Add(this.magicfPrice);
            this.Controls.Add(this.healPrice);
            this.Controls.Add(this.manaPrice);
            this.Controls.Add(this.coinCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.armorBuy);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.manaBuy);
            this.Controls.Add(this.swordBuy);
            this.Controls.Add(this.magicBuy);
            this.Controls.Add(this.healBuy);
            this.Name = "shopForm";
            this.Text = "shopForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.armorBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox healBuy;
        private System.Windows.Forms.PictureBox magicBuy;
        private System.Windows.Forms.PictureBox swordBuy;
        private System.Windows.Forms.PictureBox armorBuy;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox manaBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coinCount;
        private System.Windows.Forms.Label manaPrice;
        private System.Windows.Forms.Label healPrice;
        private System.Windows.Forms.Label magicfPrice;
        private System.Windows.Forms.Label swordPrice;
        private System.Windows.Forms.Label armorPrice;
    }
}