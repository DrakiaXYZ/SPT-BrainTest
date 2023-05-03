using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class GoToCoverPointLogic : CustomLogic
    {
        private GClass131 baseLogic;
        public GoToCoverPointLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass131(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
