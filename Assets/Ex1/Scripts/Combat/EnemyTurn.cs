using System.Collections;
using UnityEngine;

namespace Com.BeuStudio.TurnBasedGame.Combat
{
    public class EnemyTurn : State
    {
        public EnemyTurn(BattleSystem battleSystem) : base(battleSystem) { }

        public override IEnumerator Start()
        {
            if (BattleSystem.Enemy.CurrentHealth <= BattleSystem.Enemy.TotalHealth * 0.2f)
            {
                BattleSystem.SetState(new Yield(BattleSystem));
            }

            BattleSystem.Interface.SetDialogText($"{BattleSystem.Enemy.Name} attacks!");

            var isDead = BattleSystem.Player.Damage(BattleSystem.Enemy.Attack);

            yield return new WaitForSeconds(1f);

            if (isDead)
            {
                BattleSystem.SetState(new Lost(BattleSystem));
            }
            else
            {
                BattleSystem.SetState(new PlayerTurn(BattleSystem));
            }
        }
    }
}