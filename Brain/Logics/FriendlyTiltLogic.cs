using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class FriendlyTiltLogic : CustomLogic
    {
        private GClass255 baseLogic;
        public FriendlyTiltLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass255(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
