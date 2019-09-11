using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Game
{
    public partial class shopForm : Form
    {
        public async void WaitTimeBeforeClose(int time)
        {
            await Task.Delay(time);
            Hide();
        }
        public shopForm()
        {
            InitializeComponent();
            coinCount.Text = mainForm2.gameLogic.coins.ToString();
            armorPrice.Text = mainForm2.ArmorPrice.ToString();
            swordPrice.Text = mainForm2.SwordPrice.ToString();
            WaitTimeBeforeClose(17000);
        }

        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Shop will be closed now", "Close Form",
               MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.No)
            {
                // Cancel the Closing event
                e.Cancel = false;
            }
        }



        private void ManaBuy_Click(object sender, EventArgs e)
        {
            mainForm2.gameLogic.BuyItemFromShop(Engine.ItemsToUse.ManaPotion, Convert.ToInt32(manaPrice.Text));
            coinCount.Text = mainForm2.gameLogic.coins.ToString();
        }

        private void HealBuy_Click(object sender, EventArgs e)
        {
            mainForm2.gameLogic.BuyItemFromShop(Engine.ItemsToUse.HealPotion, Convert.ToInt32(healPrice.Text));
            coinCount.Text = mainForm2.gameLogic.coins.ToString();
        }

        private void MagicBuy_Click(object sender, EventArgs e)
        {
            mainForm2.gameLogic.BuyItemFromShop(Engine.ItemsToUse.MagicFruit, Convert.ToInt32(magicfPrice.Text));
            coinCount.Text = mainForm2.gameLogic.coins.ToString();
        }

        private void SwordBuy_Click(object sender, EventArgs e)
        {
            mainForm2.gameLogic.BuyItemFromShop(Engine.ItemsToUpgrade.Sword, Convert.ToInt32(swordPrice.Text), mainForm2.gameLogic.swordItem + 1);
            coinCount.Text = mainForm2.gameLogic.coins.ToString();
            swordPrice.Text = Math.Ceiling(Convert.ToInt32(swordPrice.Text) * 1.5).ToString();
            mainForm2.SwordPrice = Convert.ToInt32(swordPrice.Text);
        }

        private void ArmorBuy_Click(object sender, EventArgs e)
        {
            mainForm2.gameLogic.BuyItemFromShop(Engine.ItemsToUpgrade.Armor, Convert.ToInt32(armorPrice.Text), mainForm2.gameLogic.armorItem + 1);
            coinCount.Text = mainForm2.gameLogic.coins.ToString();
            armorPrice.Text = Math.Ceiling(Convert.ToInt32(armorPrice.Text) * 1.5).ToString();
            mainForm2.ArmorPrice = Convert.ToInt32(armorPrice.Text);
        }
    }
}
