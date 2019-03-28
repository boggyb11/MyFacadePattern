
namespace MyFacadePattern
{
    class BossBattle
    {
        private BossQuest _bossQuest = new BossQuest();
        private Level _level = new Level();
        private SecretEnding _secretEnding = new SecretEnding();

        public bool CanChallengeBoss(Player player)
        {
            bool canFightBoss = true;

            if (!_bossQuest.HasCompletedQuestToChallengeBoss())
            {
                canFightBoss = false;
            }
            if (!_level.IsHighEnoughLevel())
            {
                canFightBoss = false;
            }
            if(!_secretEnding.HasUnlockedSecretEnding())
            {
                canFightBoss = false;
            }

            return canFightBoss;
        }
    }
}
