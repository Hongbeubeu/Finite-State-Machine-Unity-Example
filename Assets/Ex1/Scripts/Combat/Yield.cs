using System.Collections;

namespace Com.BeuStudio.TurnBasedGame.Combat
{
    public class Yield : State
    {
        public Yield(BattleSystem battleSystem) : base(battleSystem) { }

        public override IEnumerator Start()
        {
            BattleSystem.Interface.SetDialogText($"{BattleSystem.Enemy.Name} has yielded.");
            yield break;
        }
    }
}