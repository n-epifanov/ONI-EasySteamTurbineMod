using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Harmony;
using JetBrains.Annotations;

/*
Need to change from:
118	0157	ldarg.1
119	0158	ldloc.0
120	0159	ldloc.2
121	015A	sub
122	015B	ldarg.0
123	015C	call	instance !2 class StateMachine`4/GenericInstance<class Turbine/States, class Turbine/Instance, class Turbine, object>::get_master()
124	0161	ldfld	float32 Turbine::requiredMassFlowDifferential
125	0166	clt
126	0168	stind.i1

to:
118	0157	ldarg.1
119	0158	ldloc.0
120	0159	ldarg.0
121	015A	call	instance !2 class StateMachine`4/GenericInstance<class Turbine/States, class Turbine/Instance, class Turbine, object>::get_master()
122	015F	ldfld	float32 Turbine::requiredMassFlowDifferential
123	0164	clt
124	0166	stind.i1
*/

namespace EasySteamTurbineMod
{
    [HarmonyPatch(typeof(Turbine.Instance))]
    [HarmonyPatch("CanSteamFlow")]
    public static class Turbine_Instance_CanSteamFlow_Patch
    {
        private static OpCode[] codes_from = new OpCode[] {
            OpCodes.Ldarg_1,
            OpCodes.Ldloc_0,
            OpCodes.Ldloc_2,
            OpCodes.Sub,
            OpCodes.Ldarg_0,
            OpCodes.Call,
            OpCodes.Ldfld,
            OpCodes.Clt,
            OpCodes.Stind_I1
        };

        static bool match(ref List<CodeInstruction> codes, int start)
        {
            try
            {
                for (int fidx = 0; fidx < codes_from.Count(); fidx++)
                {
                    if (codes[start + fidx].opcode != codes_from[fidx])
                        return false;
                }
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        static void apply(ref List<CodeInstruction> codes, int start)
        {
            codes.RemoveRange(start+2, 2);
        }

        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);
            bool found = false;
            int patch_idx = -1;
            for (int i = 0; i < codes.Count; i++)
            {
                if (match(ref codes, i))
                {
                    apply(ref codes, i);
                    found = true;
                    patch_idx = i;
                    break;
                }
            }
            if (found)
                Debug.Log("EasySteamTurbineMod: patch applied");
            else
                Debug.Log("EasySteamTurbineMod: failed to apply patch");
            /*
            for (int i = 0; i < codes.Count; i++)
            {
                if (i == patch_idx)
                    Debug.Log("<< Patch starts here");
                Debug.Log(codes[i]);
            }
            */
            return codes.AsEnumerable();
        }
    }
}
