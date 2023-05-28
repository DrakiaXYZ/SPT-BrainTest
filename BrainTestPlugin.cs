using BepInEx;
using DrakiaXYZ.BigBrain.Brains;
using DrakiaXYZ.BrainTest.Brain;
using System.Collections.Generic;

namespace DrakiaXYZ.BrainTest
{
    [BepInPlugin("xyz.drakia.braintest", "DrakiaXYZ-BrainTest", "0.1.0")]
    [BepInDependency("xyz.drakia.bigbrain", "0.1.0")]
    public class BrainTestPlugin : BaseUnityPlugin
    {
        private void Awake()
        {
            BrainManager.RemoveLayer("PatrolAssault", new List<string>() { "Assault" });
            BrainManager.AddCustomLayer(typeof(PatrolAssaultLayer), new List<string>() { "Assault" }, 2);
        }
    }
}
