using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class AlternativePatrolLogic : CustomLogic
    {
        private GClass240 baseLogic;
        public AlternativePatrolLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass240(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
