using BepInEx;
using DrakiaXYZ.BigBrain.Brains;
using DrakiaXYZ.BrainTest.Brain;
using System.Collections.Generic;

namespace DrakiaXYZ.BrainTest
{
    [BepInPlugin("xyz.drakia.braintest", "DrakiaXYZ-BrainTest", "1.3.0")]
    [BepInDependency("xyz.drakia.bigbrain", "1.3.0")]
    public class BrainTestPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            BrainManager.RemoveLayer("PatrolAssault", new List<string>() { "Assault", "PMC" });
            BrainManager.AddCustomLayer(typeof(PatrolAssaultLayer), new List<string>() { "Assault", "PMC" }, 100);
        }
    }
}
