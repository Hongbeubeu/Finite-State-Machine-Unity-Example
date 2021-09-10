using UnityEngine;
namespace Com.BeuStudio.Ex2
{
    public class ReturnHomeState : State
    {
        private Vector3 destination = new Vector3(0.1f, 0.1f, 0f);

        public ReturnHomeState(Character character) : base(character)
        {
        }

        public override void Tick()
        {
            character.MoveToward(destination);

            if (ReachedHome())
            {
                character.SetState(new WanderState(character));
            }
        }

        public override void OnStateEnter()
        {
            character.GetComponent<Renderer>().material.color = Color.blue;
        }

        private bool ReachedHome()
        {
            return Vector3.Distance(character.transform.position, destination) < 0.5f;
        }
    }
}