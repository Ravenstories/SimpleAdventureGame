using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsComplete { get; set; }
        
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsComplete = false;
        }
    }
}
