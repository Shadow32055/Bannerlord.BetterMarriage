using HarmonyLib;

using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.CampaignBehaviors;

namespace BetterMarriage {
    [HarmonyPatch(typeof(RomanceCampaignBehavior), "conversation_player_opens_courtship_on_consequence")]
    class Patches {

        public static bool Prefix() {

            ChangeRomanticStateAction.Apply(Hero.MainHero, Hero.OneToOneConversationHero, Romance.RomanceLevelEnum.CourtshipStarted);

            return false;
        }
            
    }
}
