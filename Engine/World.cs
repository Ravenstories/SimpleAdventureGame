using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        //Placeholders for ID for now, need to have every entity and items in the world. 
        public const int ITEM_ID_ITEM_PLACEHOLDER = 1;
        public const int ITEM_ID_WEAPON_PLACEHOLDER = 2;
        public const int ITEM_ID_HEALING_PLACEHOLDER = 3;

        public const int MONSTER_ID_PLACEHOLDER = 1;

        public const int QUEST_ID_PLACEHOLDER = 1;

        public const int LOCATION_ID_INN_ROOM = 1;
        public const int LOCATION_ID_INN_THE_IRON_CUP = 2;
        public const int LOCATION_ID_TOWNSQUARE = 3;
        public const int LOCATION_ID_PRISON = 4;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Item(ITEM_ID_ITEM_PLACEHOLDER, "Placeholder", "Placeholder items"));
            Items.Add(new Weapon(ITEM_ID_WEAPON_PLACEHOLDER, "Test Weapon", "Test Weapons", "A placeholder weapon", 1, 2));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_PLACEHOLDER, "Test Potion", "Test Potions", 5));

        }

        private static void PopulateMonsters()
        {
            Monster enemy = new Monster(MONSTER_ID_PLACEHOLDER, "Enemy_Placeholder", 1, 2, 1, 0, 0);
            enemy.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ITEM_PLACEHOLDER), 75, false));

            Monsters.Add(enemy);
        }

        private static void PopulateQuests()
        {
            Quest placeholderTestQuest = new Quest(QUEST_ID_PLACEHOLDER, "Placeholder Quest", "Testing Quest mechanic, kill enemy", 1, 5);

            placeholderTestQuest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_ITEM_PLACEHOLDER), 1));

            placeholderTestQuest.RewardItem = ItemByID(ITEM_ID_HEALING_PLACEHOLDER);

            Quests.Add(placeholderTestQuest);
        }

        private static void PopulateLocations()
        {
            //Create locations and add ID's to them. Monsters and quests assigned to locations is also added here. 
            Location innRoom = new Location(LOCATION_ID_INN_ROOM, "You inn room", "This is the room you are staying in at the in 'The Iron Cup' the home of the mercenary band 'The Iron Daggers'");
            
            Location innIronCup = new Location(LOCATION_ID_INN_THE_IRON_CUP, "Inn 'The Iron Cup'", "The room is brightly lit and the mood is high");
            innIronCup.QuestAvailableHere = QuestByID(QUEST_ID_PLACEHOLDER);
           
            Location townSquare = new Location(LOCATION_ID_TOWNSQUARE, "Townsquare", "The main square. You can find a lot of vendors from every corner of the continent here.");
            townSquare.MonsterLivingHere = MonsterByID(MONSTER_ID_PLACEHOLDER);

            Location prison = new Location(LOCATION_ID_PRISON, "", "");
            prison.ItemRequiredToEnter = ItemByID(ITEM_ID_ITEM_PLACEHOLDER);

            //Linking rooms together.
            //Main room, starting location. 
            innRoom.LocationToEast = innIronCup;

            //Iron Cup Inn
            innIronCup.LocationToWest = innRoom;
            innIronCup.LocationToSouth = townSquare;

            //Townsquare
            townSquare.LocationToNorth = innIronCup;
            townSquare.LocationToEast = prison;

            //Prison
            prison.LocationToWest = townSquare;
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;               
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
