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
    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();

            UpdateCounters();
        }

        public async void UpdateCounters()
        {
            while (true)
            {
                await Task.Delay(200);
                healPotionInventoryCount.Text = mainForm2.gameLogic.healPotion.ToString();
                manaPotionInventoryCount.Text = mainForm2.gameLogic.manaPotion.ToString();
                coinInventoryCount.Text = mainForm2.gameLogic.coins.ToString();
                magicFruitInventoryCount.Text = mainForm2.gameLogic.magicFruit.ToString();

                killsCount.Value = mainForm2.gameLogic.kills;

                killsAtm.Text = mainForm2.gameLogic.kills.ToString();

                
            }
        }

        Engine engine = new Engine();

        private void manaPotionUsed(object sender, EventArgs e)
        {
            if(mainForm2.gameLogic.manaPotion > 0)
            {
                mainForm2.UseItemFromInventory(mainForm2.ItemsFromInventory.ManaPotion);
            }
            else
            {
                MessageBox.Show("You dont have this item :(");
            }
        }

        private void healPotionUsed(object sender, EventArgs e)
        {
            if (mainForm2.gameLogic.healPotion > 0)
            {
                mainForm2.UseItemFromInventory(mainForm2.ItemsFromInventory.HealPotion);
            }
            else
            {
                MessageBox.Show("You dont have this item :(");
            }
        }

        private void magicFruitUsed(object sender, EventArgs e)
        {
            if (mainForm2.gameLogic.magicFruit > 0)
            {
                mainForm2.UseItemFromInventory(mainForm2.ItemsFromInventory.MagicFruit);
            }
            else
            {
                MessageBox.Show("You dont have this item :(");
            }
        }


        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Do you want to close inventory? If you close it, you cant open it again (bug or something idk)", "Close box", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            e.Cancel = true;
        }
    }
}
