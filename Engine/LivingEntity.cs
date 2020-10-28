using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
	public class LivingEntity
	{
		public int CurrentHitPoints { get; set; }
		public int MaximumHitPoints { get; set; }
		
		public LivingEntity(int currentHitPoints, int maximumHitPoints)
		{
			CurrentHitPoints = currentHitPoints;
			MaximumHitPoints = maximumHitPoints;
		}
	}

}
