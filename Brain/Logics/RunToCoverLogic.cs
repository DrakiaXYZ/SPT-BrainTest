using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class RunToCoverLogic : CustomLogic
    {
        private GClass146 baseLogic;
        public RunToCoverLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass146(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
