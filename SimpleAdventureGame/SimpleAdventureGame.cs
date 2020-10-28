using System;
using Engine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAdventureGame
{
	public partial class SimpleAdventureGame : Form
	{
		private Player _player;
        private Monster _currentMonster;

		public SimpleAdventureGame()
		{
			InitializeComponent();

			_player = new Player(10, 10, 20, 1, 0);
            MoveTo(World.LocationByID(World.LOCATION_ID_INN_ROOM));
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_WEAPON_PLACEHOLDER), 1));

			lblHitPoints.Text = _player.CurrentHitPoints.ToString();
			lblGold.Text = _player.Gold.ToString();
			lblLevel.Text = _player.Level.ToString();
			lblExperience.Text = _player.Experience.ToString();
		}


        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }
        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }
        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }
        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

        }
        private void btnPotion_Click(object sender, EventArgs e)
        {

        }

        private void MoveTo(Location newLocation)
        {
            //Does location need required items?
            if (newLocation.ItemRequiredToEnter != null)
            {
                //Does player posses required item?
                bool playerHasRequiredItem = false;

                foreach (InventoryItem item in _player.Inventory)
                {
                    if (item.Details.ID == newLocation.ItemRequiredToEnter.ID)
                    {
                        //Player has Item
                        playerHasRequiredItem = true;
                        break;
                    }
                }
                if (!playerHasRequiredItem)
                {
                    richTextBoxMessages.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                    return;
                }
            }
            // Update Player Location
            _player.CurrentLocation = newLocation;

            //Show and Hide available movement buttons
            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);
            btnWest.Visible = (newLocation.LocationToWest != null);

            //Display current location
            richTextBoxLocation.Text = newLocation.Name + Environment.NewLine;
            richTextBoxLocation.Text = newLocation.Description + Environment.NewLine;

            //Does the location have a quest?
            if(newLocation.QuestAvailableHere != null)
            {
                bool playerAlreadyHaveQuest = false;
                bool playerAlreadyCompletedQuest = false;

                foreach (PlayerQuest quest in _player.Quests)
                {
                    if (quest.Details.ID == newLocation.QuestAvailableHere.ID)
                    {
                        playerAlreadyHaveQuest = true;

                        if (quest.IsComplete)
                        {
                            playerAlreadyHaveQuest = true;
                        }
                    }
                }

                //See if the player has the quest
                if (playerAlreadyHaveQuest)
                {
                    if (!playerAlreadyCompletedQuest)
                    {
                        //Does player have all items?
                        bool playerHasItemsToCompleteQuest = true;

                        foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                        {
                            bool foundItemsInPlayersInventory = false;

                            //Check to see if player has required items
                            foreach (InventoryItem ii in _player.Inventory)
                            {
                                if (ii.Details.ID == qci.Details.ID)
                                {
                                    foundItemsInPlayersInventory = true;

                                    //Check to see if player has enough items. 
                                    if (ii.Quantity < qci.Quantity)
                                    {
                                        //Inventory Items is Lower than Quest Complete Items so it can't complete quest
                                        playerHasItemsToCompleteQuest = false;
                                        break;
                                    }
                                    break;
                                }
                            }

                            if (!foundItemsInPlayersInventory)
                            {
                                playerHasItemsToCompleteQuest = false;
                                break;
                            }
                        }
                        //The player has all the items
                        if (playerHasItemsToCompleteQuest)
                        {
                            richTextBoxMessages.Text += Environment.NewLine;
                            richTextBoxMessages.Text += "You have completed the '" + newLocation.QuestAvailableHere.Name + "' quest";

                            //Remove quest items from inventory
                            foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                            {
                                foreach (InventoryItem ii in _player.Inventory)
                                {
                                    if (ii.Details.ID == qci.Details.ID)
                                    {
                                        //Subtracts items to complete quest
                                        ii.Quantity -= qci.Quantity;
                                        break;
                                    }
                                }
                            }
                            richTextBoxMessages.Text += "You recieve: " + Environment.NewLine;
                            richTextBoxMessages.Text += newLocation.QuestAvailableHere.RewardExperience.ToString() + " experience points" + Environment.NewLine;
                            richTextBoxMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            richTextBoxMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            richTextBoxMessages.Text += Environment.NewLine;

                            _player.Experience += newLocation.QuestAvailableHere.RewardExperience;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            //Add reward items
                            bool addedItemToPlayerInventory = false;

                            foreach (InventoryItem ii in _player.Inventory)
                            {
                                if (ii.Details.ID == newLocation.QuestAvailableHere.RewardItem.ID)
                                {
                                    //If they have the item, add one
                                    ii.Quantity++;

                                    addedItemToPlayerInventory = true;

                                    break;
                                }
                            }
                            //The player don't have the reward item, so create a new instance of that item
                            if (!addedItemToPlayerInventory)
                            {
                                _player.Inventory.Add(new InventoryItem(newLocation.QuestAvailableHere.RewardItem, 1));
                            }

                            //Mark the quest as completed
                            foreach (PlayerQuest pq in _player.Quests)
                            {
                                if (pq.Details.ID == newLocation.QuestAvailableHere.ID)
                                {
                                    pq.IsComplete = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    //The player don't have the quest

                    richTextBoxMessages.Text += "You recieve the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine;
                    richTextBoxMessages.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                    richTextBoxMessages.Text += "You need to retuen with: " + Environment.NewLine;
                    foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if(qci.Quantity == 1)
                        {
                            richTextBoxMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            richTextBoxMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    richTextBoxMessages.Text += Environment.NewLine;
                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));

                }                
            }

            //Does the location have a monster?

            if (newLocation.MonsterLivingHere != null)
            {
                richTextBoxMessages.Text += "You see a " + newLocation.MonsterLivingHere + Environment.NewLine;

                //Create new monster
                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints, standardMonster.MaximumDamage, standardMonster.RewardExperience, standardMonster.RewardGold);

                foreach(LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                //Remember to fix this, so the comboboxes can become invisible when not in use and visible when needed
                //comboBoxWeapons.Visible = true;
                //comboBoxPotions.Visible = true;
                btnAttack.Visible = true;
                btnPotion.Visible = true;
            }
            else
            {
                _currentMonster = null;

                //comboBoxWeapons.Visible = false;
                //comboBoxPotions.Visible = false;
                btnAttack.Visible = false;
                btnPotion.Visible = false;
            }

            dataGridViewInventory.ColumnCount = 2;
            dataGridViewInventory.Columns[0].Name = "Name";
            dataGridViewInventory.Columns[0].Width = 197;
            dataGridViewInventory.Columns[0].Name = "Quantity";
            dataGridViewInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dataGridViewInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }

            dataGridViewQuests.ColumnCount = 2;
            dataGridViewQuests.Columns[0].Name = "Name";
            dataGridViewQuests.Columns[0].Width = 197;
            dataGridViewQuests.Columns[0].Name = "Done?";
            dataGridViewQuests.Rows.Clear();

            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                dataGridViewQuests.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsComplete.ToString() });
            }

        }
    }
}
