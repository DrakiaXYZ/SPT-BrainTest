using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class PeacefulLogic : CustomLogic
    {
        private GClass176 baseLogic;
        public PeacefulLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass176(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
