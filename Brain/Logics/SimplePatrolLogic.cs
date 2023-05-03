using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class SimplePatrolLogic : CustomLogic
    {
        private GClass155 baseLogic;
        public SimplePatrolLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass155(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
