using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
	class Weapon : Item
	{
		public string Description { get; set; }
		public int MinimumDamage { get; set; }
		public int MaximumDamage { get; set; }

		public Weapon(int id, string name, string namePlural, string description, int minimumDamage, int maximumDamage) : base(id, name, namePlural) 
		{
			Description = description;
			MinimumDamage = minimumDamage;
			MaximumDamage = maximumDamage;
		}
	}
}
