using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class AlternativePatrolLogic : CustomLogic
    {
        private GClass156 baseLogic;
        public AlternativePatrolLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass156(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
