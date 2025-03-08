using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class PeaceLookLogic : CustomLogic
    {
        private GClass261 baseLogic;
        public PeaceLookLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass261(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
