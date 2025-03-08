using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class HealLogic : CustomLogic
    {
        private GClass190 baseLogic;
        public HealLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass190(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
