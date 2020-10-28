using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class Player : LivingEntity
	{
		public int Gold { get; set; }
		public int Level { get; set; }
		public int Experience { get; set; }
		public Location CurrentLocation { get; set; }
		public List<InventoryItem> Inventory { get; set; }
		public List<PlayerQuest> Quests { get; set; }

		public Player(int currentHitPoints, int maximumHitPoints, int gold, int level, int experience) : base(currentHitPoints, maximumHitPoints)
        {
			Gold = gold;
			Level = level;
			Experience = experience;

			Inventory = new List<InventoryItem>();
			Quests = new List<PlayerQuest>();
        }
	}
}
