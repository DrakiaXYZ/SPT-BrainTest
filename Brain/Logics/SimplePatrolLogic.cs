using DrakiaXYZ.BigBrain.Brains;
using EFT;
using System.Text;
using UnityEngine;

namespace DrakiaXYZ.BrainTest.Brain.Logics
{
    internal class SimplePatrolLogic : CustomLogic
    {
        private GClass243 baseLogic;
        public SimplePatrolLogic(BotOwner botOwner) : base(botOwner)
        {
            baseLogic = new GClass243(botOwner);
        }

        public override void Update(CustomLayer.ActionData data)
        {
            baseLogic.UpdateNodeByBrain(data);
        }

        public override void BuildDebugText(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("Some Data: From Logioc");
            stringBuilder.AppendLabeledValue("Label", "This is Logic", Color.blue, Color.green, true);
        }
    }
}
