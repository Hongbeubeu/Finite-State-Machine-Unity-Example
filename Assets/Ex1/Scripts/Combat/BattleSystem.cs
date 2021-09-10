using UnityEngine;

namespace Com.BeuStudio.TurnBasedGame.Combat
{
    public class BattleSystem : StateMachine
    {
        [SerializeField] private BattleUI ui;
        [SerializeField] private Fighter player;
        [SerializeField] private Fighter enemy;

        public Fighter Player => player;
        public Fighter Enemy => enemy;
        public BattleUI Interface => ui;

        private void Start()
        {
            InitStart();
            Interface.Initialize(player, enemy);
            SetState(new Begin(this));
        }

        void InitStart()
        {
            player.OnValidate();
            enemy.OnValidate();
        }

        public void OnAttackButton()
        {
            StartCoroutine(State.Attack());
        }

        public void OnHealButton()
        {
            StartCoroutine(State.Heal());
        }
    }
}