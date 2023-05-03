using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class WatchSecondWeaponLogic : CustomLogic
    {
        private GClass179 baseLogic;
        public WatchSecondWeaponLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass179(botOwner);
        }

        public override void Update()
        {
            baseLogic.Update();
        }
    }
}
