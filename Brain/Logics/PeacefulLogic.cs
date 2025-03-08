using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class PeacefulLogic : CustomLogic
    {
        private GClass259 baseLogic;
        public PeacefulLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass259(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
