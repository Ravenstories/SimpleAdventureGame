using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
	public class Quest
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int RewardExperience { get; set; }
		public int RewardGold { get; set; }
		public Item RewardItem { get; set; }
		public List<QuestCompletionItem> QuestCompletionItems { get; set; }

		public Quest(int id, string name, string description, int rewardExperience, int rewardGold) 
		{
			ID = id;
			Name = name;
			Description = description;
			RewardExperience = rewardExperience;
			RewardGold = rewardGold;
			QuestCompletionItems = new List<QuestCompletionItem>();
		}
	}
}
