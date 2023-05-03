using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class HealLogic : CustomLogic
    {
        private GClass122 baseLogic;
        public HealLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass122(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
