using BetterCore.Utils;
using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BetterMarriage {
    public class SubModule : MBSubModuleBase {

        protected override void OnSubModuleLoad() {
            base.OnSubModuleLoad();

            Harmony h = new("Bannerlord.Shadow.BetterMarriage");

            h.PatchAll();
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();

            string modName = base.GetType().Assembly.GetName().Name;

            Helper.SetModName(modName);
        }
	}
}