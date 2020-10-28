using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
	public class Monster : LivingEntity
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int MaximumDamage { get; set; }
		public int RewardExperience { get; set; }
		public int RewardGold { get; set; }
		public List<LootItem> LootTable { get; set; }

		public Monster(int id, string name, int currentHitPoints, int maximumHitPoints, int maximumDamage, int rewardExpeience, int rewardGold) : base(currentHitPoints, maximumHitPoints)
        {
			ID = id;
			Name = name;
			MaximumDamage = maximumDamage;
			RewardExperience = rewardExpeience;
			RewardGold = rewardGold;
			LootTable = new List<LootItem>();
        }
	}
}
