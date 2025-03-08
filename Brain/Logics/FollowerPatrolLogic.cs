using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class FollowerPatrolLogic : CustomLogic
    {
        private GClass241 baseLogic;
        public FollowerPatrolLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass241(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
