using GlobalSettings;
using HarmonyLib;

namespace NoShardCap.Helpers
{
    [HarmonyPatch(typeof(Gameplay), "GetCurrencyCap")]
    public static class Gameplay_GetCurrencyCap
    {
        [HarmonyPostfix]
        public static void Postfix(CurrencyType type, ref int __result)
        {
            if (type == CurrencyType.Shard)
            {
                __result = int.MaxValue;
            }
        }
    }
}