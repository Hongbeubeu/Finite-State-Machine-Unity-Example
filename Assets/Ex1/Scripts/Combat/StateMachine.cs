using UnityEngine;
namespace Com.BeuStudio.TurnBasedGame.Combat
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected State State;
        public void SetState(State state)
        {
            State = state;
            StartCoroutine(State.Start());
        }
    }
}