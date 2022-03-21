using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BetterMarriage {
	public class SubModule : MBSubModuleBase {

		protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();
			new Harmony("Bannerlord.Shadow.BetterMarriage").PatchAll();
			Helper.SetModName("BetterMarriage");
		}
	}
}