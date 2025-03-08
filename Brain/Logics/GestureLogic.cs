using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class GestureLogic : CustomLogic
    {
        private GClass256 baseLogic;
        public GestureLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass256(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
