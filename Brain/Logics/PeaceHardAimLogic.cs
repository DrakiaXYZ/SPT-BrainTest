using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class PeaceHardAimLogic : CustomLogic
    {
        private GClass174 baseLogic;
        public PeaceHardAimLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass174(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
