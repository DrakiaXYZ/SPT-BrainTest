using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class EatDrinkLogic : CustomLogic
    {
        private GClass169 baseLogic;
        public EatDrinkLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass169(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
