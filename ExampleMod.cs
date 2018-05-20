using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using JetBrains.Annotations;

namespace Patches
{
    public static class ExampleMod
    {
        // Some examples.
        /*
        [HarmonyPatch(typeof(LiquidPumpConfig), nameof(LiquidPumpConfig.CreateBuildingDef))]
        public static class LiquidPumpConfigPatch
        {
            public static void Postfix([NotNull] ref BuildingDef __result)
            {
                __result.OverheatTemperature = 1273.15f;
            }
        }
        */
        /*
        [HarmonyPatch(typeof(StorageLockerConfig), nameof(StorageLockerConfig.CreateBuildingDef))]
        public static class StorageLockerConfigPatch
        {
            public static void Postfix([NotNull] ref BuildingDef __result)
            {
                __result.BuildLocationRule = BuildLocationRule.Tile;
                __result.ContinuouslyCheckFoundation = false;
            }
        }
        */
    }
}
