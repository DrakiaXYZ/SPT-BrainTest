using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class FriendlyTiltLogic : CustomLogic
    {
        private GClass170 baseLogic;
        public FriendlyTiltLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass170(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
