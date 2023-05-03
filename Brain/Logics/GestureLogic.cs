using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class GestureLogic : CustomLogic
    {
        private GClass171 baseLogic;
        public GestureLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass171(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
