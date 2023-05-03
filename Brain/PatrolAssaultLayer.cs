using DrakiaXYZ.BigBrain.Brains;
using EFT;

namespace DrakiaXYZ.BrainTest.Brain
{
    internal class PatrolAssaultLayer : CustomLayer
    {
        public PatrolAssaultLayer(BotOwner botOwner, int priority) : base(botOwner, priority)
        {
        }

        public override string GetName()
        {
            return "PatrolAssault";
        }

        public override Action GetNextAction()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsActive()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsCurrentActionEnding()
        {
            throw new System.NotImplementedException();
        }
    }
}
