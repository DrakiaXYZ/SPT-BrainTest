using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class FollowerPatrolLogic : CustomLogic
    {
        private GClass157 baseLogic;
        public FollowerPatrolLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass157(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
