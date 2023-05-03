using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class PeaceLookLogic : CustomLogic
    {
        private GClass175 baseLogic;
        public PeaceLookLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass175(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
