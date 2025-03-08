using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class EatDrinkLogic : CustomLogic
    {
        private GClass254 baseLogic;
        public EatDrinkLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass254(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
