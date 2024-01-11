using BetterCore.Utils;
using HarmonyLib;
using System;
using TaleWorlds.MountAndBlade;

namespace BetterMarriage {
    public class BetterMarriage : MBSubModuleBase {

        public static string ModName { get; private set; } = "BetterMarriage";

        private bool isInitialized = false;
        private bool isLoaded = false;

        //FIRST
        protected override void OnSubModuleLoad() {
            try {
                base.OnSubModuleLoad();

                if (isInitialized)
                    return;

                Harmony h = new("Bannerlord.Shadow." + ModName);

                h.PatchAll();

                isInitialized = true;
            } catch (Exception e) {
                NotifyHelper.ReportError(ModName, "OnSubModuleLoad threw exception " + e);
            }
        }

        //SECOND
        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
            try {
                base.OnBeforeInitialModuleScreenSetAsRoot();

                if (isLoaded)
                    return;

                ModName = base.GetType().Assembly.GetName().Name;


                NotifyHelper.ChatMessage(ModName + " Loaded.", MsgType.Good);
                Integrations.BetterMarriageLoaded = true;

                isLoaded = true;
            } catch (Exception e) {
                NotifyHelper.ReportError(ModName, "OnBeforeInitialModuleScreenSetAsRoot threw exception " + e);
            }
        }
    }
}