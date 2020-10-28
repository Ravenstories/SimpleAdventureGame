﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
	class HealingPotion : Item
	{
		public int AmountToHeal { get; set; }

		public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
		{
			AmountToHeal = amountToHeal;
		}

	}
}
