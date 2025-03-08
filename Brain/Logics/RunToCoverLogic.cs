using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class RunToCoverLogic : CustomLogic
    {
        private GClass221 baseLogic;
        public RunToCoverLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass221(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByMain(data);
        }
    }
}
