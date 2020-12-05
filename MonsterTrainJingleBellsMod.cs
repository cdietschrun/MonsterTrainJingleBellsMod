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

    [HarmonyPatch(typeof(CharacterData))]
    [HarmonyPatch("GetName")]
    public static class NameChangerFrank
    {
        private static void Postfix(ref string __result)
        {
            if (__result == "Hornbreaker Prince")
            {
                __result = "Frank";
            }
        }
    }

    [HarmonyPatch(typeof(CardState))]
    [HarmonyPatch("GetTitle")]
    public static class NameChangerFrankCard
    {
        private static void Postfix(ref string __result)
        {
            if (__result == "Hornbreaker Prince")
            {
                __result = "Frank";
            }
        }
    }
}
