using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class PeaceHardAimLogic : CustomLogic
    {
        private GClass260 baseLogic;
        public PeaceHardAimLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass260(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
