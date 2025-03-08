using DrakiaXYZ.BigBrain.Brains;
using EFT;
namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class GoToCoverPointLogic : CustomLogic
    {
        private GClass205 baseLogic;
        public GoToCoverPointLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass205(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByMain(data);
        }
    }
}
