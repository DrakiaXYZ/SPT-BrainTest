using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class WatchSecondWeaponLogic : CustomLogic
    {
        private GClass264 baseLogic;
        public WatchSecondWeaponLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass264(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }
    }
}
