using BepInEx;
using HarmonyLib;

namespace MonsterTrainJingleBellsMod
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    public class JingleBellsMod : BaseUnityPlugin
    {
        public const string GUID = "com.github.cdietschrun.MonsterTrainInvulnerableMod";
        public const string NAME = "Invulnerable Pyre Mod";
        public const string VERSION = "1.0.0";

        private void Awake()
        {
            var harmony = new Harmony(GUID);
            harmony.PatchAll();
        }
    }
}
