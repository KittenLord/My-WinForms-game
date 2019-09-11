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
    public partial class mainForm2 : Form 
    {

        public mainForm2()
        {

            InitializeComponent();

            xCounter.Text = nulCoordinate.Location.X.ToString();
            yCounter.Text = nulCoordinate.Location.Y.ToString();

            gameLogic = new Engine(playerUnit, DoOnTouchEvents, progressBarHP, coinCounter, manaCounter);
            gameLogic.UpdateCounterValue(Engine.StatsCounters.Mana);
            gameLogic.coins += 80;
            UpdateAllCounters();

            //Registering
            gameLogic.RegisterEntity(nulCoordinate, Engine.EntityType.Entity);


            SetAlotOfFuckingWalls();


            SetAllBlocks();




            gameLogic.EnemyAIChecking();


            ShowDialog();
            Close();


            
        }

        public PictureBox[] wallsArray = new PictureBox[36];

        public PictureBox[] shopsArray = new PictureBox[7];

        public PictureBox[] enemyArray = new PictureBox[35];

        public static int SwordPrice = 20;
        public static int ArmorPrice = 20;

        public void SetAlotOfFuckingWalls()
        {
            for (int i = 0; i < wallsArray.Length; i++)
            {
                wallsArray[i] = new PictureBox();
            }
            for (int i = 0; i < wallsArray.Length; i++)
            {
                wallsArray[i].Image = Properties.Resources.wall_texture;
                wallsArray[i].Location = new Point(500, 500);
                wallsArray[i].Name = $"wall{i + 1}";
                wallsArray[i].Size = new Size(120, 120);
                wallsArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                wallsArray[i].TabIndex = 9;
                wallsArray[i].TabStop = false;
                wallsArray[i].Visible = true;
                Controls.Add(wallsArray[i]);
                gameLogic.RegisterEntity(wallsArray[i], Engine.EntityType.Obstacle);
            }

            for (int i = 0; i < shopsArray.Length; i++)
            {
                shopsArray[i] = new PictureBox();
            }
            for (int i = 0; i < shopsArray.Length; i++)
            {
                shopsArray[i].Image = Properties.Resources.shop;
                shopsArray[i].Location = new Point(500, 500);
                shopsArray[i].Name = $"shop{i + 1}";
                shopsArray[i].Size = new Size(150, 105);
                shopsArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                shopsArray[i].TabIndex = 9;
                shopsArray[i].TabStop = false;
                shopsArray[i].Visible = true;
                Controls.Add(shopsArray[i]);
                gameLogic.RegisterEntity(shopsArray[i], Engine.EntityType.UsableItem);
            }

            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i] = new PictureBox();
            }
            Random rnd = new Random();
            for (int i = 0; i < enemyArray.Length; i++)
            {

                
                enemyArray[i].Location = new Point(500, 500);
                enemyArray[i].Name = $"enemyUnit{i + 1}";
                //enemyArray[i].Size = new Size(140,140) ;
                enemyArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                enemyArray[i].TabIndex = 9;
                enemyArray[i].TabStop = false;
                enemyArray[i].Visible = true;
                Controls.Add(enemyArray[i]);
                

                switch (rnd.Next(1, 7))
                {
                    case 1:
                    case 2:
                    case 3:
                        gameLogic.RegisterEntity(enemyArray[i], Engine.EnemyEntityTag.Ork);
                        enemyArray[i].Image = Properties.Resources.orkSkin;
                        break;

                    case 4:
                    case 5:
                        gameLogic.RegisterEntity(enemyArray[i], Engine.EnemyEntityTag.Skeleton);
                        enemyArray[i].Image = Properties.Resources.skeletonSkin;
                        break;

                    case 6:
                        gameLogic.RegisterEntity(enemyArray[i], Engine.EnemyEntityTag.Dragon);
                        enemyArray[i].Image = Properties.Resources.dragonSkin;
                        break;
                }
            }
        }

        public void SetBlock(Control block, int x, int y)
        {
            block.Location = new Point(x, y);
        }

        public void SetAllBlocks()
        {
            Random rnd = new Random();
            for(int i = 0; i < wallsArray.Length; i++)
            {
                wallsArray[i].Location = new Point( playerUnit.Location.X + rnd.Next(-10, 11) * 100 , playerUnit.Location.Y + rnd.Next(-10, 10) * 100 );
            }
            for(int i = 0; i < shopsArray.Length; i++)
            {
                shopsArray[i].Location = new Point(playerUnit.Location.X + rnd.Next(-10, 11) * 100, playerUnit.Location.Y + rnd.Next(-10, 10) * 100);
            }
            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i].Location = new Point(playerUnit.Location.X + rnd.Next(-13, 14) * 100, playerUnit.Location.Y + rnd.Next(-10, 10) * 100);
            }
        }

        public int DoOnTouchEvents()
        {
            // if(gameLogic.TestForUses(player, entity)){ code }

            if(gameLogic.TestForUses(playerUnit, shopsArray[0]) || gameLogic.TestForUses(playerUnit, shopsArray[1]) || gameLogic.TestForUses(playerUnit, shopsArray[2]) || gameLogic.TestForUses(playerUnit, shopsArray[3]) || gameLogic.TestForUses(playerUnit, shopsArray[4]) || gameLogic.TestForUses(playerUnit, shopsArray[5]) || gameLogic.TestForUses(playerUnit, shopsArray[6]))
            {
                shopForm shopForm = new shopForm();
                shopForm.Show();
            }
            return 0;
        }

        public async void UpdateAllCounters()
        {
            while (true)
            {
                coinCounter.Text = gameLogic.coins.ToString();
                manaCounter.Text = gameLogic.playerMana.ToString();
                swordCounter.Text = gameLogic.swordItem.ToString();
                armorCounter.Text = gameLogic.armorItem.ToString();

                if(gameLogic.kills >= enemyArray.Length)
                {
                    MessageBox.Show("Congratulations! You won!");
                    await Task.Delay(4000);
                    Engine.CloseProgram();
                }

                await Task.Delay(100);
            }
        }

        

        public static void UseItemFromInventory(ItemsFromInventory itemToUse)
        {
            switch (itemToUse)
            {
                case ItemsFromInventory.HealPotion:
                    gameLogic.UseItem(Engine.ItemsToUse.HealPotion);
                    break;

                case ItemsFromInventory.MagicFruit:
                    gameLogic.UseItem(Engine.ItemsToUse.MagicFruit);
                    break;

                case ItemsFromInventory.ManaPotion:
                    gameLogic.UseItem(Engine.ItemsToUse.ManaPotion);
                    break;
            }
        }

        public enum ItemsFromInventory
        {
            HealPotion, ManaPotion, MagicFruit
        }


        public inventoryForm inventory = new inventoryForm();

        public static Engine gameLogic;

        private void controlButtonPressed(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyValue)
            {
                case (char)Keys.W:
                    gameLogic.MoveIfWayIsFree('w');
                    dirPointer.Text = "UP";

                    break;

                case (char)Keys.A:
                    gameLogic.MoveIfWayIsFree('a');
                    dirPointer.Text = "LF";

                    break;

                case (char)Keys.S:
                    gameLogic.MoveIfWayIsFree('s');

                    dirPointer.Text = "DN";
                    break;

                case (char)Keys.D:
                    gameLogic.MoveIfWayIsFree('d');
                    dirPointer.Text = "RT";

                    break;

                case (char)Keys.F:
                    gameLogic.CheckForUsables();
                    break;

                case (char)Keys.E:
                    try
                    {
                        inventory.Show();
                    }
                    catch
                    {
                        MessageBox.Show("You stupid noob you closed inventory and it is no longer accessible, mind your business better next time, dumbass");
                    }

                    break;

                case (char)Keys.U:
                    MessageBox.Show("Game is closed now");
                    Engine.CloseProgram();
                    break;

                case (char)Keys.F1:
                    MessageBox.Show("\t\t\tKeys:\n\n\n" +
                                    "Press W, A, S, D to move around\n\n" +
                                    "Press F to use usable thing, loot chests or attack mobs\n\n" +
                                    "Press E to open inventory\n\n" +
                                    "Press U to close the game\n\n" +
                                    "Press F1 to see this message\n\n" +
                                    "Press F3 to toggle/untoggle special stats\n\n" +
                                    "\n AND DONT FUCKING CLOSE INVENTORY AT ALL COSTS" +
                                    "\n\n\n" +
                                    "\t\t\tItems:\n\n\n" +
                                    "Heal potion: heals some hp for you.\n\n" +
                                    "Mana potion: increases your regeneration\n\n" +
                                    "Magic fruit: Teleports you to random block in" +
                                    "certain radius; useful to escape mobs.\n\n" +
                                    "Coins: Buy items for them\n\n" +
                                    "Sword: Increases your damage\n\n" +
                                    "Armor: Increases your defence\n\n\n\n" +
                                    "\t\t\tMobs:\n\n" +
                                    "There are 3 mobs: Ork, Skeleton and Dragon." +
                                    "The higher level is mob, more items it drops," +
                                    "but more difficult it is to defeat." +
                                    "\n\n\n\n\n\n\n\n" +
                                    "\tGame created by KittenLord in 2019");
                    break;



                case (char)Keys.F3:
                    xP.Visible = !xP.Visible;
                    yP.Visible = !yP.Visible;
                    dirP.Visible = !dirP.Visible;

                    xCounter.Visible = !xCounter.Visible;
                    yCounter.Visible = !yCounter.Visible;
                    dirPointer.Visible = !dirPointer.Visible;
                    break;
            }

            xCounter.Text = nulCoordinate.Location.X.ToString();
            yCounter.Text = nulCoordinate.Location.Y.ToString();
        }
    }















    public class Engine
    {
        public Engine(Control player, Func<int> doOnTouchEvents, ProgressBar progressHpBar, Label coinCounter, Label manaCounter)
        {
            this.player = player;
            DoOnTouchEvents = doOnTouchEvents;
            progressHpBar.Value = maxPlayerHP;
            this.progressHpBar = progressHpBar;
            this.coinCounter = coinCounter;
            this.manaCounter = manaCounter;
        }

        public Engine() { }

        Label coinCounter;
        Label manaCounter;
        ProgressBar progressHpBar;

        public Control player = null; // Important stuff
        public Func<int> DoOnTouchEvents;

        public enum EnemyEntityTag
        {
            Ork, Skeleton, Dragon
        } // Enemy ranks (higher rank == more damage n more hp i suppose

        public enum EntityType
        {
            Entity, EnemyEntity, Obstacle, UsableItem
        } // Used when registering a new entity

        public enum ItemsToUpgrade
        {
            Sword, Armor
        } // Items you can upgrade

        public enum ItemsToUse
        {
            HealPotion, ManaPotion, MagicFruit
        } // Usable items

        public enum StatsCounters
        {
            Coins, Mana, Sword, Armor
        }

        public void UpdateCounterValue(StatsCounters counter)
        {
            switch (counter)
            {
                case StatsCounters.Coins:
                    coinCounter.Text = coins.ToString();
                    break;

                case StatsCounters.Mana:
                    manaCounter.Text = (playerMana - 10).ToString();
                    break;

                case StatsCounters.Sword:

                    break;

                case StatsCounters.Armor:

                    break;
            }
        }

        public void BuyItemFromShop(ItemsToUse item, int price)
        {
            if (coins >= price)
            {
                coins -= price;
                switch (item)
                {
                    case ItemsToUse.HealPotion:
                        healPotion++;
                        break;

                    case ItemsToUse.MagicFruit:
                        magicFruit++;
                        break;

                    case ItemsToUse.ManaPotion:
                        manaPotion++;
                        break;
                }
            }
            else
            {
                MessageBox.Show("You dont have enough money to buy this item :(");
            }
        } // Buys misc stuff from shop

        public void BuyItemFromShop(ItemsToUpgrade item, int price, int newLevel)
        {
            if (coins >= price)
            {
                UpgradeItem(newLevel, item);
                coins -= price;
            }
            else
            {
                MessageBox.Show("You dont have enough money to buy this item :(");
            }
        } // Buys armor and sword from shop

        public void UseItem(ItemsToUse item)
        {
            switch (item)
            {
                case ItemsToUse.HealPotion:
                    if (healPotion > 0)
                    {
                        HealPlayersHP(30);
                        UpdateHPBar();
                        healPotion--;
                    }
                    break;

                case ItemsToUse.MagicFruit:
                    if (magicFruit > 0)
                    {
                        MoveIfPlayerUsedMagicFruit();
                        magicFruit--;
                    }
                    break;

                case ItemsToUse.ManaPotion:
                    if (manaPotion > 0)
                    {
                        if (playerMana + 1 <= maxPlayerMana)
                            playerMana++;
                        UpdateCounterValue(StatsCounters.Mana);
                        manaPotion--;
                    }
                    break;
            }
        } // Uses item

        public void RegisterEntity(Control entity, EntityType addMode)
        {

            switch (addMode)
            {
                case EntityType.Entity:
                    moveObj.Add(entity);
                    this.entity.Add(entity);
                    break;

                case EntityType.Obstacle:
                    moveObj.Add(entity);
                    obstacle.Add(entity);
                    break;

                case EntityType.UsableItem:
                    moveObj.Add(entity);
                    usableItem.Add(entity);
                    break;
            }

        } // Registering entity

        public void RegisterEntity(PictureBox entity, EnemyEntityTag enemyTag)
        {
            moveObj.Add(entity);
            enemyEntity.Add(entity);
            entity.Tag = enemyTag;
            entity.BackColor = Color.Transparent;
            entity.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (enemyTag)
            {
                case EnemyEntityTag.Ork:
                    entity.Width = 120;
                    entity.Height = 120;
                    break;

                case EnemyEntityTag.Skeleton:
                    entity.Width = 160;
                    entity.Height = 160;
                    break;

                case EnemyEntityTag.Dragon:
                    entity.Width = 260;
                    entity.Height = 260;
                    break;
            }
        } // Registering enemy entity

        public void RegenPlayer()
        {
            regenHP++;
            if (regenHP >= 50)
            {
                if (playerHP + playerMana > maxPlayerHP) playerHP = maxPlayerHP;
                else playerHP += playerMana;
                regenHP = 0;
                UpdateHPBar();
            }
        } // Healing player

        public void UpdateHPBar()
        {
            progressHpBar.Value = playerHP;
        }

        public void HealPlayersHP(int hp)
        {
            if (playerHP + hp > maxPlayerHP) playerHP = maxPlayerHP;
            else playerHP += hp;
        } // Heals player on certain hp

        public void DamagePlayer(Control enemy)
        {
            switch (enemy.Tag)
            {
                case EnemyEntityTag.Ork:
                    if (playerHP - Convert.ToInt32(8 / armorItem) < 0) playerHP = 0;
                    else playerHP -= Convert.ToInt32(8 / armorItem);
                    break;

                case EnemyEntityTag.Skeleton:
                    if (playerHP - Convert.ToInt32(17 / armorItem) < 0) playerHP = 0;
                    else playerHP -= Convert.ToInt32(17 / armorItem);
                    break;

                case EnemyEntityTag.Dragon:
                    if (playerHP - Convert.ToInt32(38/ armorItem) < 0) playerHP = 0;
                    else playerHP -= Convert.ToInt32(38 / armorItem);
                    break;
            }
            UpdateHPBar();
            IsDead();
        } // Damaging player depending on enemy's rank

        public void DamagePlayer(int damage)
        {
            if (playerHP - damage < 0) playerHP = 0;
            else playerHP -= damage;
            UpdateHPBar();
            IsDead();
        }

        public void DamageEntity(Control entity, int limit) // Summon this when entity shall be damaged
        {
            entity.Size = new Size(entity.Width - playerDamage * swordItem, entity.Height - playerDamage * swordItem);
            IsDead(entity, limit);
        }

        public void UpgradeItem(int newItemLevel, ItemsToUpgrade itemName)
        {
            switch (itemName)
            {
                case ItemsToUpgrade.Armor:
                    if (newItemLevel > armorItem) armorItem = newItemLevel;
                    break;

                case ItemsToUpgrade.Sword:
                    if (newItemLevel > swordItem) swordItem = newItemLevel;
                    break;
            }
        } // Tests to pickup an item, if it is better than one you have

        public void EnemyGotKilledGiveLoot(EnemyEntityTag enemy)
        {
            Random rnd = new Random();
            int randomLoot = rnd.Next(0, 101);
            switch (enemy)
            {
                case EnemyEntityTag.Ork:

                    if (randomLoot >= 0 && randomLoot <= 60) coins += 5;
                    else if (randomLoot >= 61 && randomLoot <= 80) { coins += 10; UpgradeItem(2, ItemsToUpgrade.Sword); }

                    break;

                case EnemyEntityTag.Skeleton:
                    if (randomLoot >= 0 && randomLoot <= 40) coins += 12;
                    else if (randomLoot >= 41 && randomLoot <= 70) { coins += 17; magicFruit++; }
                    else if (randomLoot >= 71 && randomLoot <= 95) { coins += 20; UpgradeItem(2, ItemsToUpgrade.Armor); }
                    else if (randomLoot >= 96 && randomLoot <= 100) { coins += 25; UpgradeItem(3, ItemsToUpgrade.Sword); }

                    break;

                case EnemyEntityTag.Dragon:

                    if (randomLoot >= 0 && randomLoot <= 50) { coins += 40; healPotion++; }
                    if (randomLoot >= 51 && randomLoot <= 80) { coins += 50; manaPotion++; magicFruit++; }
                    if (randomLoot >= 81 && randomLoot <= 100) { coins += 6; manaPotion++; healPotion++; magicFruit++; UpgradeItem(3, ItemsToUpgrade.Armor); }

                    break;
            }
        } // Dropping random loot from enemies

        public void IsDead(Control entity, int limit) // Checks if entity is dead, and "destroys" it, if it is
        {
            if (entity.Width < limit) { entity.Location = new Point(entity.Location.X + 9999, entity.Location.Y + 9999); EnemyGotKilledGiveLoot((EnemyEntityTag)entity.Tag); UpdateCounterValue(StatsCounters.Coins); kills++; entity.Dispose(); }
        }

        public async void IsDead()
        {
            if (playerHP <= 0)
            {
                MessageBox.Show("You are dead :(");
                for (int i = 0; i < 8; i++)
                {
                    player.Size = new Size(player.Width - 7, player.Height - 7);
                    await Task.Delay(100);
                }
                player.Size = new Size(0, 0);
                player.Visible = false;
                progressHpBar.Value = maxPlayerHP;
                await Task.Delay(2000);
                CloseProgram();
            }
        } //Checks if player is dead

        public async void EnemyAI(PictureBox enemy)
        {
            int distance = 0;
            //int waitTime = 0;
            switch (enemy.Tag)
            {
                case EnemyEntityTag.Ork:
                    distance = 1000;
                    //waitTime = 300;
                    break;
                case EnemyEntityTag.Skeleton:
                    distance = 1500;
                    //waitTime = 700;
                    break;
                case EnemyEntityTag.Dragon:
                    distance = 2000;
                    //waitTime = 1500;
                    break;
            }
            if ( Math.Abs(enemy.Location.X - player.Location.X) <= distance && Math.Abs(enemy.Location.Y - player.Location.Y) < distance )

            {
                //Point enemyLoc = enemy.Location;
                enemy.Location = new Point( (enemy.Location.X + player.Location.X)/2, (enemy.Location.Y + player.Location.Y)/2 );
                //foreach (Control control in obstacle)
                //{
                //    if (TestForUses(enemy, control))
                //    {
                //        enemy.Location = enemyLoc;
                //        return;
                //    }
                //}
                //await Task.Delay(waitTime);
            }
        }



        /// <summary>
        /// Player Stats
        /// </summary>

        public int playerHP = 150; // Player HP

        public int playerMana = 15; // Player Mana

        public int regenHP = 0; // Counts, until to heal player

        public int playerDamage = 15; // How many damage does player deal

        int maxPlayerHP = 150; // Player's hp limitation

        int maxPlayerMana = 35; // Player's mana limitation

        public int kills = 0;



        public int swordItem = 1;

        public int armorItem = 1;

        public int healPotion = 0;

        public int magicFruit = 0;

        public int manaPotion = 0;

        public int coins = 0;


        public bool level1Key = false;

        public bool level2Key = false;

        public bool level3Key = false;

        /// <summary>
        /// Player Stats
        /// </summary>



        public List<Control> moveObj = new List<Control>(); // Entity types

        public List<Control> entity = new List<Control>();

        public List<PictureBox> enemyEntity = new List<PictureBox>();

        public List<Control> obstacle = new List<Control>();

        public List<Control> usableItem = new List<Control>();




        public bool TestForUses(Control player, Control usage)
        {
            if ((player.Location.Y + player.Height >= usage.Location.Y && player.Location.X + player.Width >= usage.Location.X) && (player.Location.Y <= usage.Location.Y + usage.Height && player.Location.X <= usage.Location.X + usage.Width)) return true; return false;
        } // Checks if you can do something with entity / anything

        public bool TestForCollision(Control collider, Control obstacle, char direction)
        {
            switch (direction)
            {
                case 'w':

                    if ((collider.Location.Y < obstacle.Location.Y + obstacle.Height && collider.Location.Y > obstacle.Location.Y) && (collider.Location.X + collider.Width > obstacle.Location.X && collider.Location.X < obstacle.Location.X + obstacle.Width)) return false; else return true;

                case 'a':

                    if ((collider.Location.X < obstacle.Location.X + obstacle.Width && collider.Location.X > obstacle.Location.X) && (collider.Location.Y + collider.Height > obstacle.Location.Y && collider.Location.Y < obstacle.Location.Y + obstacle.Height)) return false; else return true;

                case 's':

                    if ((collider.Location.Y + collider.Height > obstacle.Location.Y && collider.Location.Y < obstacle.Location.Y) && (collider.Location.X + collider.Width > obstacle.Location.X && collider.Location.X < obstacle.Location.X + obstacle.Width)) return false; else return true;

                case 'd':

                    if ((collider.Location.X + collider.Width > obstacle.Location.X && collider.Location.X < obstacle.Location.X) && (collider.Location.Y + collider.Height > obstacle.Location.Y && collider.Location.Y < obstacle.Location.Y + obstacle.Height)) return false; else return true;
            }

            return true;
        } // Tests if you go in the wall

        public void MoveIfWayIsFree(char controlKey) // Checks if player can move, and moves if it can
        {


            int movePts = 0; // How many blocks player shall move

            bool VerticalTrueHorFalse = controlKey == 'w' || controlKey == 's'; // Is direction vertical or horizontal

            for (int i = 0; i < obstacle.Count; i++) // Checks if player collides with anything, stops function if yes 
            {
                if (!TestForCollision(player, obstacle[i], controlKey))
                    return;
            }


            switch (controlKey) // How many points should player move
            {
                case 'w':
                case 'a':
                    movePts = 10;
                    break;
                case 'd':
                case 's':
                    movePts = -10;
                    break;
            }


            for (int i = 0; i < moveObj.Count; i++) // "Moving" player
            {
                if (VerticalTrueHorFalse)
                    moveObj[i].Location = new Point(moveObj[i].Location.X, moveObj[i].Location.Y + movePts);
                else
                    moveObj[i].Location = new Point(moveObj[i].Location.X + movePts, moveObj[i].Location.Y);
            }

            CheckForDamagingPlayer();

            

            RegenPlayer();
        }

        public async void EnemyAIChecking()
        {
            //await Task.Delay(3000);
            while (true)
            {
                for (int i = 0; i < enemyEntity.Count; i++)
                {
                    await Task.Delay(1250);
                    EnemyAI(enemyEntity[i]);
                    CheckForDamagingPlayer();
                    
                }
            }
        }

        public void MoveIfPlayerUsedMagicFruit()
        {
            Random rnd = new Random();
            int rndX = rnd.Next(-120, 121);
            int rndY = rnd.Next(-120, 121);
            for (int i = 0; i < moveObj.Count; i++)
            {
                moveObj[i].Location = new Point(moveObj[i].Location.X + rndX, moveObj[i].Location.Y + rndY);
            }
            CheckForDamagingPlayer();
            DamagePlayer(30);
        } // Uses magic fruit, if it is being used

        public void CheckForDamagingPlayer()
        {
            for (int i = 0; i < enemyEntity.Count; i++) // Checks if enemy is nearby, and if yes, damages player
            {
                if (TestForUses(player, enemyEntity[i]))
                {
                    DamagePlayer(enemyEntity[i]);
                }
            }
        } // Checks if player is being damaged

        public void TestForPlayerAbleToAttack()
        {
            for (int i = 0; i < enemyEntity.Count; i++)
            {
                if (TestForUses(player, enemyEntity[i]))
                {
                    DamageEntity(enemyEntity[i], 70);
                    IsDead();
                }
            }
        } // Checks if player can attack enemies

        public static void CloseProgram()
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        } // Stops program, cuz ye

        public void CheckForUsables()
        {
            CheckForDamagingPlayer();
            TestForPlayerAbleToAttack();

            // Here goes other usables, to add one, use if(TestForUses(player, entity)) // do something...
            DoOnTouchEvents();
        } // Tests if there's something player can use
    } 
}
