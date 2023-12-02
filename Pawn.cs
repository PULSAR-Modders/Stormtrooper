using HarmonyLib;

namespace Stormtrooper
{
    [HarmonyPatch(typeof(PLPawn), "Update")]
    internal class Pawn
    {
        static void Postfix(PLPawn __instance)
        {
            if (__instance != PLNetworkManager.Instance.LocalPlayer.GetPawn()) return;
            __instance.CurrentAccuracyRating = 100000f;
        }
    }
}
